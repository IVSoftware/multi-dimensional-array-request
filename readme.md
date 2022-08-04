# Multi Dimensional Array Request

Example of a multidimensional array that uses an array syntax `_array[1][5] = 0xff` to display a value at the correct index on one of four `ChildTest` forms, an outcome that is achieved using data bindings. The benefit of doing this is that the `ChildTest` labels update automatically after the initial setup. This walk-through will demonstrate how to do that.

**USAGE**

    private void buttonClear2_Click(object sender, EventArgs e) 
    { 
        for (int cell = 0; cell < 28; cell++) _array[0, cell] = 0x00; 
    }

![before and after clear](https://github.com/IVSoftware/multi-dimensional-array-request/blob/master/multi-dimensional-array-request/ReadMe/before-and-after-clear.png)

    private void buttonTest1_Click(object sender, EventArgs e) => _array[0,0] = 0xFF;

![before and after test](https://github.com/IVSoftware/multi-dimensional-array-request/blob/master/multi-dimensional-array-request/ReadMe/before-and-after-test.png)

***
**Observable uint**

The bindings are based on a `uint` value that sends a notification whenever its value changes. This class works behind the scenes to keep everything synced.

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

***
**Multidimensional array class**

The multidimensional array provides a standard array indexer that gets and sets a `uint` value using `_array[bank][index] = 0xnn`. Under the hood are arrays made from these observable uints but it makes no difference in terma of interacting with the multidimensional array.

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

***
**`ChildTest` form class**

This is a `Form` with a `TableLayoutPanel` on it that is unremarkable except for the addition of a `DataSource` property. It is here that the observable uints are bound to the textbox values.

    public partial class ChildTest : Form
    {
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
    }

***
**`MainForm` Constructor**

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



