using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFSJ.ViewModels
{
    public class BrowseFileViewModel : BaseViewModel
    {
        string text = string.Empty;

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }
    }
}
