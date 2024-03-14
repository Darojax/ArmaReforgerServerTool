namespace ReforgerServerApp
{
    public partial class ServerParameterSelect : ServerParameter
    {

        public ServerParameterSelect()
        {
            InitializeComponent();
            underlyingControl = parameterValue;
        }

        public override object ParameterValue
        {
            get => parameterValue.SelectedText;
            set => parameterValue.SelectedText = (string)value;
        }

        public ComboBox.ObjectCollection Selection
        {
            set
            {
                parameterValue.Items.Clear();
                foreach (string item in value)
                {
                    parameterValue.Items.Add(item);
                }
            }
        }
    }
}
