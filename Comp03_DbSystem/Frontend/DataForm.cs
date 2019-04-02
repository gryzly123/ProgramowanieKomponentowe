using System;
using System.Windows.Forms;

namespace Frontend
{
    public enum DataAction
    {
        AddNew,
        ReadAndModify,
        ConfirmDelete
    }

    //we can't implement this as inherited class of object Forms
    //because C# is garbage, but it should look like this.
    public class DataForm
    {
        public /*const*/ DataAction da;

        public DataForm(DataAction _da)
        {
            da = _da;
        }

        public bool FieldAccess => da != DataAction.ConfirmDelete;
    }
}
