using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudentskaMenzaUWP.Servisi
{
    public interface INavigacijskiServis
    {
        string TrenutnaStranica { get; }

        void IdiNaStranicu(string page);

        /// <summary>
        /// Navigates to the specified page and
        /// supply additional page-specific parameters.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="parameter"></param>
        void NavigateTo(string page, object parameter);

        void IdiNazad();
    }
}
