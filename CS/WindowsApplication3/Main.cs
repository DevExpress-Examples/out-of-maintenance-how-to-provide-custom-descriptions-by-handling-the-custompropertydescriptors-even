using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid;


namespace DXSample {
    public partial class Main: XtraForm {
        public Main() {
            InitializeComponent();
        }
       
        private void OnCustomPropertyDescriptors(object sender, DevExpress.XtraVerticalGrid.Events.CustomPropertyDescriptorsEventArgs e)
        {
            PropertyGridControl grid = sender as PropertyGridControl;
            PropertyDescriptorCollection sourceColl = TypeDescriptor.GetProperties(grid.SelectedObject);
            PropertyDescriptorCollection destColl = new PropertyDescriptorCollection(null);
            foreach (PropertyDescriptor pd in sourceColl)
                destColl.Add(new MyPropertyDescriptor(pd));
            e.Properties = destColl;
        }
    }
}
