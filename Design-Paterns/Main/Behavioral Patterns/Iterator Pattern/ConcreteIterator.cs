﻿using System;

namespace Main.Behavioral_Patterns.Iterator_Pattern
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        int index;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
            index = -1;
        }

        public bool Next()
        {
            index++;
            return index < aggregate.Count;
        }

        public object Current
        {
            get
            {
                if (index < aggregate.Count)
                    return aggregate[index];
                else
                    throw new InvalidOperationException();
            }
        }
    }
}
