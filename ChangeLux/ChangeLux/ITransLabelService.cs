using System;
using Xamarin.Forms;

namespace ChangeLux
{
    public interface ITransLabelService
    {
        void TransModel(Label label);
        void TransDes(Label label);
    }
}
