using System.Windows.Input;
using Xamarin.Forms;

namespace TextOnImage
{
    public class SamplePageViewModel : BindableBase
    {
        private string _stringImage;

        public string StringImage
        {
            get { return _stringImage ?? "Hello Everyone"; }
            set { Set(() => StringImage, ref _stringImage, value); }
        }

        private Color _stringColor = Color.Lime;

        public Color StringColor
        {
            get { return _stringColor; }
            set { Set(() => StringColor, ref _stringColor, value); }
        }
        private DelegateCommand _changeStringCommand;

        public ICommand ChangeStringCommand
            => _changeStringCommand ?? (_changeStringCommand = new DelegateCommand(ChangeStringCommandAction));

        private void ChangeStringCommandAction()
        {
            StringImage = "Hello Trung DZ";
            StringColor = Color.Red;            
        }
    }
}
