using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using System.ComponentModel;

namespace DXSample {
    public class MyPropertyDescriptor : PropertyDescriptor
    {
        PropertyDescriptor pd;

        public MyPropertyDescriptor(PropertyDescriptor pd)
            : base(pd)
        {
            this.pd = pd;
        }

        public override string Description
        {
            get
            {
                return string.Format("=====Custom Description:======\r\n {0}", base.Description);
            }
        }

        public override Type ComponentType
        {
            get { return pd.ComponentType; }
        }
        public override bool IsReadOnly
        {
            get { return pd.IsReadOnly; }
        }

        public override Type PropertyType
        {
            get { return pd.PropertyType; }
        }

        public override bool CanResetValue(object component)
        {
            return pd.CanResetValue(component);
        }

        public override object GetValue(object component)
        {
            return pd.GetValue(component);
        }
        public override void ResetValue(object component)
        {
            pd.ResetValue(component);
        }
        public override void SetValue(object component, object value)
        {
            pd.SetValue(component, value);
        }
        public override bool ShouldSerializeValue(object component)
        {
            return pd.ShouldSerializeValue(component);
        }
    }
}