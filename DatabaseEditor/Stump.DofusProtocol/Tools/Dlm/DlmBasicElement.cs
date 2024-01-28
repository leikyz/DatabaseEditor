using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.D2oClasses.Tools.Dlm
{
    public abstract class DlmBasicElement
    {
        public enum ElementTypesEnum
        {
            Graphical = 2,
            Sound = 33
        }

        protected DlmBasicElement(DlmCell cell)
        {
            Cell = cell;
        }

        public DlmCell Cell { get; private set; }

        public static DlmBasicElement ReadFromStream(DlmCell cell, IDataReader reader)
        {
            DlmBasicElement dlmBasicElement;
            var num = reader.ReadByte();
            var elementTypesEnum = (ElementTypesEnum) num;
            if (elementTypesEnum == ElementTypesEnum.Graphical)
            {
                dlmBasicElement = DlmGraphicalElement.ReadFromStream(cell, reader);
            }
            else
            {
                if (elementTypesEnum != ElementTypesEnum.Sound)
                {
                    object[] id = {"Unknown element ID : ", num, " CellID : ", cell.Id};
                    throw new Exception(string.Concat(id));
                }
                dlmBasicElement = DlmSoundElement.ReadFromStream(cell, reader);
            }
            return dlmBasicElement;
        }
    }
}