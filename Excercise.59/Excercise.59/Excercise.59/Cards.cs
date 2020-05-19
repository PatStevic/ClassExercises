using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise._59
{
    class Cards
    {
        public Rank Rank { get; }
        public Suite Suite { get; }

        public Cards( Rank rank, Suite suite)
        {
            Rank = rank;
            Suite = suite;
        }
    }
}
