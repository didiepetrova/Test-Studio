using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace ToStartFolders
{

    public class Combo : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"KendoInput: Combo open ")]
        public void Combo_CodedStep()
        {
            // KendoInput: Combo open 
            Pages.DemoForJQueryPowered.Span0.ToggleCombo();
            
        }
    
        [CodedStep(@"KendoListBox: select item by text 'L - 7 1/8'")]
        public void Combo_CodedStep1()
        {
            // KendoListBox: select item by text 'L - 7 1/8"'
            Pages.DemoForJQueryPowered.SizeListboxUnorderedList.SelectItem("L - 7 1/8\"");
            
        }
    
        [CodedStep(@"KendoListBox: select item by text 'L - 7 1/8'")]
        public void Combo_CodedStep2()
        {
            // KendoListBox: select item by text 'L - 7 1/8"'
            Pages.DemoForJQueryPowered.SizeListboxUnorderedList.SelectItem("L - 7 1/8\"");
            
        }
    }
}
