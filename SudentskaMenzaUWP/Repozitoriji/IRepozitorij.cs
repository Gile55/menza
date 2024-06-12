using System.Collections.Generic;

namespace SudentskaMenza.Repozitoriji
{
    internal interface IRepozitorij<T>
    {
        T dohvatiJedan();

        List<T> dohvatiSve();

        void spremi(T t);
    }
}
