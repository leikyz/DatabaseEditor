using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Stump.Core.Reflection;
using Stump.DofusProtocol.Classes;
using IDataObject = Stump.DofusProtocol.Classes.IDataObject;

namespace DatabaseEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isDragging = false;
        private Point startPoint;
        private readonly Dictionary<Type, List<Type>> m_subTypes = new Dictionary<Type, List<Type>>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DraggableElement_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isDragging = true;
            startPoint = e.GetPosition(null);
            DraggableElement.CaptureMouse();
        }

        private void DraggableElement_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && e.LeftButton == MouseButtonState.Pressed)
            {
                Point currentPoint = e.GetPosition(null);
                Vector diff = startPoint - currentPoint;

                if (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                    Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance)
                {
                    DragDrop.DoDragDrop(DraggableElement, DraggableElement, DragDropEffects.Move);
                    isDragging = false;
                    DraggableElement.ReleaseMouseCapture();
                }
            }
        }

        private void DraggableElement_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isDragging = false;
            DraggableElement.ReleaseMouseCapture();
        }
        private void FindSubClasses()
        {
            var types = typeof(AbuseReasons).Assembly.GetTypes();
            for (var i = 0; i < types.Length; i++)
            {
                var type = types[i];
                if (type.HasInterface(typeof(IDataObject)))
                {
                    if (type.BaseType != typeof(object))
                    {
                        var baseType = type.BaseType;
                        while (baseType.BaseType != typeof(object))
                        {
                            baseType = baseType.BaseType;
                        }
                        if (!m_subTypes.ContainsKey(baseType))
                        {
                            m_subTypes.Add(baseType, new List<Type>());
                        }
                        m_subTypes[baseType].Add(type);
                    }
                }
            }
        }

        private void ShowFirstSubtypeName()
        {
            foreach (var kvp in m_subTypes)
            {
                if (kvp.Value.Any())
                {
                    var firstSubtypeName = kvp.Value.Last().Name;
                    MessageBox.Show("First Subtype Name: " + firstSubtypeName);
                    return; // Exit method after displaying the first subtype name
                }
            }
        }
        private void DropTarget_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    if (Path.GetExtension(file).ToLower() == ".d2o")
                    {
                        try
                        {
                            using (FileStream stream = new FileStream(file, FileMode.Open, FileAccess.ReadWrite))
                            {
                                D2OEditor window = new D2OEditor(stream);
                                window.WindowStartupLocation = WindowStartupLocation.Manual;
                                window.Show();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error opening file: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"File dropped: {file} (Not a .d2o file)", "File Information", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
        }
           
    }
}
