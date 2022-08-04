using System;
using System.Drawing;
using System.Windows.Forms;

namespace multi_dimensional_array_request
{
    public partial class ChildTest : Form
    {
        public ChildTest() => InitializeComponent();

        public ObservableUInt[] DataSource
        {
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 28; i++)
                    {
                        var row = (i / 7) * 2;
                        var column = i % 7;
                        // Add Label
                        var label = new Label
                        {
                            Size = new Size(width: 150, height: 50),
                            Text = $"{i + 1}",
                            TextAlign = ContentAlignment.MiddleCenter,
                            BackColor = Color.DimGray,
                            ForeColor = Color.White,
                            Anchor = (AnchorStyles)0xf,
                        };
                        tableLayoutPanel.Controls.Add(label, column, row);
                        row++;
                        // Add Textbox and bind the Formatted property to it
                        var textbox = new TextBox
                        {
                            Size = new Size(width: 150, height: 50),
                            TextAlign = HorizontalAlignment.Center,
                        };
                        tableLayoutPanel.Controls.Add(textbox, column, row);

                        textbox.DataBindings.Add(
                            nameof(Label.Text),
                            value[i],
                            nameof(ObservableUInt.Formatted),
                            false,
                            DataSourceUpdateMode.OnPropertyChanged
                         );
                    }
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
            if (e.Cancel) Hide();
        }
    }
}
