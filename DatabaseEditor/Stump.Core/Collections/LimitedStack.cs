using System;
using System.Collections.Generic;

namespace Stump.Core.Collections
{
    [Serializable]
    public class LimitedStack<T> : LinkedList<T>
    {
        private int m_maxItems;
        public int MaxItems
        {
            get
            {
                return this.m_maxItems;
            }
            set
            {
                while (base.Count > value)
                {
                    base.RemoveFirst();
                }
                this.m_maxItems = value;
            }
        }

        public LimitedStack(int num)
        {
            this.m_maxItems = num;
        }
        public LimitedStack(int num, IEnumerable<T> items)
          : base(items)
        {
            m_maxItems = num;
        }


        public T PeekPrevious()
        {
            if (base.Last == null || base.Last.Previous == null)
            {
                throw new InvalidOperationException("La liste ne contient pas assez d'éléments pour récupérer l'avant-dernier élément.");
            }
            return base.Last.Previous.Value;
        }

        public T PeekThirdFromEnd()
        {
            if (base.Last == null || base.Last.Previous == null || base.Last.Previous.Previous == null)
            {
                throw new InvalidOperationException("La liste ne contient pas assez d'éléments pour récupérer le troisième élément en partant de la fin.");
            }
            return base.Last.Previous.Previous.Value;
        }

        public T Peek()
        {
            return base.Last.Value;
        }

        public T Pop()
        {
            LinkedListNode<T> last = base.Last;
            base.RemoveLast();
            return last.Value;
        }

        public void Push(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            base.AddLast(node);
            if (base.Count > this.m_maxItems)
            {
                base.RemoveFirst();
            }
        }
    }
}