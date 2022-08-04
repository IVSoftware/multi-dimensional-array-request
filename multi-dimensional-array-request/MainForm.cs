using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace multi_dimensional_array_request
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Initialize 4 x 28 with respective index
            for (uint i = 0; i < 112; i++)
            {
                var bank = i / 28;
                var index = i % 28;
                _array[bank, index] = i + 1;
            }

            _childTest1 = new ChildTest { DataSource = _array[0] };
            _childTest2 = new ChildTest { DataSource = _array[1] };
            _childTest3 = new ChildTest { DataSource = _array[2] };
            _childTest4 = new ChildTest { DataSource = _array[3] };
        }
        private readonly MultidimensionalArray _array = new MultidimensionalArray();

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _childTest1.Dispose();
            _childTest2.Dispose();
            _childTest3.Dispose();
            _childTest4.Dispose();
            e.Cancel = false;
            base.OnFormClosing(e);
        }

        ChildTest _childTest1;
        ChildTest _childTest2;
        ChildTest _childTest3;
        ChildTest _childTest4;

        private void buttonChildTest1_Click(object sender, EventArgs e) => _childTest1.Show(this);

        private void buttonChildTest2_Click(object sender, EventArgs e) => _childTest2.Show(this);

        private void buttonChildTest3_Click(object sender, EventArgs e) => _childTest3.Show(this);

        private void buttonChildTest4_Click(object sender, EventArgs e) => _childTest4.Show(this);

        private void buttonClear1_Click(object sender, EventArgs e){ for (int cell = 0; cell < 28; cell++)  _array[0, cell] = 0x00; } 

        private void buttonClear2_Click(object sender, EventArgs e) { for (int cell = 0; cell < 28; cell++) _array[0, cell] = 0x00; }

        private void buttonClear3_Click(object sender, EventArgs e) { for (int cell = 0; cell < 28; cell++) _array[0, cell] = 0x00; }

        private void buttonClear4_Click(object sender, EventArgs e) { for (int cell = 0; cell < 28; cell++) _array[0, cell] = 0x00; }

        private void buttonTest1_Click(object sender, EventArgs e) => _array[0,0] = 0xFF;
    }

    public class MultidimensionalArray
    {
        public MultidimensionalArray()
        {
            for (uint i = 0; i < 112; i++)
            {
                _array[i / 28].Add(new ObservableUInt());
            }
        }
        public uint this[int bank, int index]
        {
            get => _array[bank][index];
            set => _array[bank][index].Value = value;
        }
        public uint this[uint bank, uint index]
        {
            get => _array[bank][(int)index];
            set => _array[bank][(int)index].Value = value;
        }
        public ObservableUInt[] this[int bank] => _array[bank].ToArray();

        ObservableCollection<ObservableUInt>[] _array =
               Enumerable.Range(0, 4)
               .Select(_ => new ObservableCollection<ObservableUInt>())
               .ToArray();
    }

    public class ObservableUInt : INotifyPropertyChanged
    {
        uint _Value = 0;
        public uint Value
        {
            get => _Value;
            set
            {
                if (!Equals(_Value, value))
                {
                    _Value = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Formatted)));
                }
            }
        }
        public string Formatted => $"0x{_Value.ToString("X2")}";

        public event PropertyChangedEventHandler PropertyChanged;
        public static implicit operator uint(ObservableUInt @this) => @this._Value;
    }
}
