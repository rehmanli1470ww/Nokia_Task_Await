using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Nokia_Task_Await
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Text { get; set; }
        public int Click { get; set; }
        public char Temp { get; set; }
        public MainWindow()
        {
            DataContext = this;
            Click = 0;
            InitializeComponent();
            Temp = '/';
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Click += 1;
            if (Click == 1)
                Temp = '1';
            else if (Click == 2)
            {
                Temp = ' ';
                Click = 0;
            }



        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Click += 1;

            switch (Click)
            {
                case 1:
                    Temp = '2';
                    break;

                case 2:
                    Temp = 'A';
                    break;

                case 3:
                    Temp = 'B';
                    break;

                case 4:
                    Temp = 'C';
                    Click=0;
                    break;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Click += 1;

            switch (Click)
            {
                case 1:
                    Temp = '3';
                    break;

                case 2:
                    Temp = 'D';
                    break;

                case 3:
                    Temp = 'E';
                    break;

                case 4:
                    Temp = 'F';
                    Click = 0;
                    break;
            }
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Click += 1;

            switch (Click)
            {
                case 1:
                    Temp = '4';
                    break;

                case 2:
                    Temp = 'G';
                    break;

                case 3:
                    Temp = 'H';
                    break;

                case 4:
                    Temp = 'I';
                    Click = 0;
                    break;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Click += 1;

            switch (Click)
            {
                case 1:
                    Temp = '5';
                    break;

                case 2:
                    Temp = 'J';
                    break;

                case 3:
                    Temp = 'K';
                    break;

                case 4:
                    Temp = 'L';
                    Click = 0;
                    break;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Click += 1;

            switch (Click)
            {
                case 1:
                    Temp = '6';
                    break;

                case 2:
                    Temp = 'M';
                    break;

                case 3:
                    Temp = 'N';
                    break;

                case 4:
                    Temp = 'O';
                    Click = 0;
                    break;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Click += 1;

            switch (Click)
            {
                case 1:
                    Temp = '7';
                    break;

                case 2:
                    Temp = 'P';
                    break;

                case 3:
                    Temp = 'Q';
                    break;
                case 4:
                    Temp = 'R';
                    break;
                case 5:
                    Temp = 'S';
                    Click = 0;
                    break;
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Click += 1;

            switch (Click)
            {
                case 1:
                    Temp = '8';
                    break;

                case 2:
                    Temp = 'T';
                    break;

                case 3:
                    Temp = 'U';
                    break;

                case 4:
                    Temp = 'V';
                    Click = 0;
                    break;
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Click += 1;

            switch (Click)
            {
                case 1:
                    Temp = '9';
                    break;

                case 2:
                    Temp = 'W';
                    break;

                case 3:
                    Temp = 'X';
                    break;
                case 4:
                    Temp = 'Y';
                    break;
                case 5:
                    Temp = 'Z';
                    Click = 0;
                    break;
            }
        }

        private void Button_Click_Ulduz(object sender, RoutedEventArgs e)
        {
            Click = 1;
            if (Click == 1)
            {
                Temp = '*';
                Click = 0;
            }
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            Click += 1;
            if (Click == 1)
               Temp = '0';
            else if (Click==2)
            {
                Temp = '+';
                Click = 0;
            }

        }

        private void Button_Click_Dies(object sender, RoutedEventArgs e)
        {
            Click = 1;
            if (Click == 1)
            {
                Temp = '#';
                Click = 0;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            if (Text != null && Text.Length != 0)
            {
                Text = Text.Remove(Text.Length - 1);
                MetnTextBox.Document.Blocks.Clear();
                MetnTextBox.AppendText(Text);
            }


        }

        private async void Add_Click(object sender, RoutedEventArgs e)
        {
            await Start();
        }

        public async Task Start()
        {
            // 1-E bosluq qoyma eleve etmisem
            //Muellim belede ede bilerem telefondaki kimi bir defe add edenden sonra silinir tempdeki data 

            await Task.Delay(500);
            if (Temp != '/')
            {
                Text += Temp;
                MetnTextBox.Document.Blocks.Clear();
                MetnTextBox.AppendText(Text);
                Click = 0;
                Temp = '/';
            }


            //Birde bele ede bilerem yaddasda saxlayir nece defe isdese add ede bilersen
            //if (Temp != '/')
            //{
            //    Text += Temp;
            //    MetnTextBox.Document.Blocks.Clear();
            //    MetnTextBox.AppendText(Text);
            //    Click = 0;
            //}
        }

    }
}