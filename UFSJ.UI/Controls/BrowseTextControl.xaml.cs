using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using UFSJ.ViewModels;

namespace UFSJ
{
    /// <summary>
    /// Interaction logic for BrowseTextControl.xaml
    /// </summary>
    public partial class BrowseTextControl : UserControl
    { 

        /// <summary>
        /// Gets or sets the value of the <see cref="Text" />
        /// property. This is a dependency property.
        /// </summary>
        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }

        /// <summary>
        /// Identifies the <see cref="Text" /> dependency property.
        /// </summary>
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            "Text",
            typeof(string),
            typeof(BrowseTextControl),
            new UIPropertyMetadata(""));


        BrowseFileViewModel _vm;
        public BrowseTextControl()
        {
            this.InitializeComponent();
            _vm = (BrowseFileViewModel)LayoutRoot.DataContext;
        }
  
    }
   
}