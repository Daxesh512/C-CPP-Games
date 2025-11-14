//Cormac Raftery G00348802
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Media.Playback;
using Windows.Media.Core;
using System.Diagnostics;
using System.Threading;
using Windows.UI.Popups;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Chessboard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        #region Global Variables _rows is essential, don't delete it
        int _rows, i, j, bombs, explode, nearbybombs=0;
        const int _iHeight = 50;
        int amountOfClicks=0;
        Stopwatch stopWatch = new Stopwatch();
        string elapsedTime;
        #endregion

        #region Constructor and set up code
        public MainPage() // constructor
        {
            this.InitializeComponent();
            this.Loading += MainPage_Loading;
        }

        private void MainPage_Loading(FrameworkElement sender, object args)
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            string strSetting;
            try
            {
                strSetting = localSettings.Values["userChoice"].ToString();
                tblSetting.Text = strSetting;
            }
            catch (Exception ex)
            {
                tblSetting.Text = "Error: " + ex.HResult + ", " + ex.Message;
            }

        }
        #endregion

        private void RadioButton_Checked(object sender, RoutedEventArgs e)//size of grid
        {
            amountOfClicks = 0;// resets count
            RadioButton current = (RadioButton)sender;
            _rows = Convert.ToInt32(current.Tag);
            createChessBoard();
            setupThePieces();
            setupTheMines();
            stopWatch.Restart();
            stopWatch.Start();
        }

        private void setupThePieces()// create an image object in every grid
        {
            Image tileImage;
            BitmapImage bitmapImage;
            bitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/unrevealedtile.png", UriKind.RelativeOrAbsolute));

            Grid localBoard = FindName("ChessBoard") as Grid;

            for (i = 0; i < _rows; i++)
            {
                for (j = 0; j < _rows; j++)
                {
                    tileImage = new Image();
                    tileImage.Height = _iHeight * 0.99;
                    tileImage.Width = _iHeight * 0.99;
                    tileImage.Source = bitmapImage;
                    tileImage.Name = "unrevealed_" + i.ToString() + "_" + j.ToString();
                    tileImage.Tapped += TileImage_Tapped;
                    tileImage.RightTapped += TileImage_RightTapped;
                    localBoard.Children.Add(tileImage);
                    tileImage.SetValue(Grid.ColumnProperty, i);
                    tileImage.SetValue(Grid.RowProperty, j);
                    tileImage.Tag = 0;
                }
            }
        }

        private void TileImage_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            amountOfClicks++;
            Image current = (Image)sender;
            explode = Convert.ToInt32(current.Tag);
            Image tileImage;
            BitmapImage bitmapImage;
            bitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/flag.png", UriKind.RelativeOrAbsolute));
            Grid localBoard = FindName("ChessBoard") as Grid;
            tileImage = new Image();
            tileImage.Height = _iHeight * 0.99;
            tileImage.Width = _iHeight * 0.99;
            tileImage.Source = bitmapImage;
            tileImage.Tapped += TileImage_Tapped;
            tileImage.Tag = explode;
            tileImage.Name = "flag";
            localBoard.Children.Add(tileImage);
            tileImage.SetValue(Grid.RowProperty, (int)current.GetValue(Grid.RowProperty));
            tileImage.SetValue(Grid.ColumnProperty, (int)current.GetValue(Grid.ColumnProperty));
        }

        private void setupTheMines()
        {
            if (_rows == 7)
            {
                bombs = 12;
           }
            else if(_rows==12)
            {
                bombs = 40;
           }
            else
            {
                bombs = 70;
          }
            Image tileImage;
            BitmapImage bitmapImage;
            bitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/unrevealedtile.png", UriKind.RelativeOrAbsolute));
            Grid localBoard = FindName("ChessBoard") as Grid;
            int col;
            int row;
            Random rnd = new Random();

            for (i = 0; i <= bombs; i++)
            {
                    row = rnd.Next(0, (_rows));
                    col = rnd.Next(0, (_rows));
                    tileImage = new Image();
                    tileImage.Height = _iHeight * 0.99;
                    tileImage.Width = _iHeight * 0.99;
                    tileImage.Source = bitmapImage;
                    tileImage.Tapped += TileImage_Tapped;
                    tileImage.RightTapped += TileImage_RightTapped;
                    localBoard.Children.Add(tileImage);
                    tileImage.SetValue(Grid.ColumnProperty, col);
                    tileImage.SetValue(Grid.RowProperty, row);
                    tileImage.Name = "bomb_" + row.ToString() + "_" + col.ToString();
                    tileImage.Tag = 1;
            }
        }
        private async void TileImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            
            int row, col;
            Image current = (Image)sender;
            explode = Convert.ToInt32(current.Tag);
            row = Convert.ToInt32((int)current.GetValue(Grid.RowProperty));
            col = Convert.ToInt32((int)current.GetValue(Grid.ColumnProperty));

            if(current.Name.Equals("flag"))
            {}
            else
            {
                amountOfClicks++;
            }
            if (amountOfClicks == (_rows * _rows))
            {
                var Msg = new MessageDialog(elapsedTime, "You win!");
                await Msg.ShowAsync();
            }
            if (explode == 1)
            {
                Image tileImage;
                BitmapImage bitmapImage;
                bitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/bomb.png", UriKind.RelativeOrAbsolute));
                Grid localBoard = FindName("ChessBoard") as Grid;
                tileImage = new Image();
                tileImage.Height = _iHeight * 0.99;
                tileImage.Width = _iHeight * 0.99;
                tileImage.Source = bitmapImage;
                localBoard.Children.Add(tileImage);
                tileImage.SetValue(Grid.RowProperty, (int)current.GetValue(Grid.RowProperty));
                tileImage.SetValue(Grid.ColumnProperty, (int)current.GetValue(Grid.ColumnProperty));
                MediaPlayer mediaPlayer = new MediaPlayer();
                mediaPlayer.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/boom.mp3"));
                mediaPlayer.Play();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch.Elapsed;
                // Format and display the TimeSpan value.
                elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                stopWatch.Stop();
                var Msg = new MessageDialog(elapsedTime, "You lose!");
                await Msg.ShowAsync();
                amountOfClicks = 0;
                createChessBoard();
                setupThePieces();
                setupTheMines();
                stopWatch.Restart();
                stopWatch.Start();
            }
            else
            {
                nearbybombs = 0;
                int namerow = (int)current.GetValue(Grid.RowProperty);
                int namecol = (int)current.GetValue(Grid.ColumnProperty);

                for (i = -1; i <= 1; i++)
                {
                    for (j = -1; j <= 1; j++)
                    {
                        try
                        {
                            Image image = FindName("bomb_" + (namerow + i).ToString() + "_" + (namecol + j).ToString()) as Image;
                            explode = Convert.ToInt32(image.Tag);
                            nearbybombs += explode;
                        }
                        catch
                        { }
                    }//for j
                }//for i
                #region huge if else statements
                if (nearbybombs == 0)
                {
                    Image tileImage;
                    BitmapImage bitmapImage;
                    bitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/tile0.png", UriKind.RelativeOrAbsolute));
                    Grid localBoard = FindName("ChessBoard") as Grid;
                    tileImage = new Image();
                    tileImage.Height = _iHeight * 0.99;
                    tileImage.Width = _iHeight * 0.99;
                    tileImage.Source = bitmapImage;
                    localBoard.Children.Add(tileImage);
                    tileImage.SetValue(Grid.RowProperty, (int)current.GetValue(Grid.RowProperty));
                    tileImage.SetValue(Grid.ColumnProperty, (int)current.GetValue(Grid.ColumnProperty));
                }
                else if (nearbybombs == 1)
                {
                    Image tileImage;
                    BitmapImage bitmapImage;
                    bitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/tile1.png", UriKind.RelativeOrAbsolute));
                    Grid localBoard = FindName("ChessBoard") as Grid;
                    tileImage = new Image();
                    tileImage.Height = _iHeight * 0.99;
                    tileImage.Width = _iHeight * 0.99;
                    tileImage.Source = bitmapImage;
                    localBoard.Children.Add(tileImage);
                    tileImage.SetValue(Grid.RowProperty, (int)current.GetValue(Grid.RowProperty));
                    tileImage.SetValue(Grid.ColumnProperty, (int)current.GetValue(Grid.ColumnProperty));
                }
                else if (nearbybombs == 2)
                {
                    Image tileImage;
                    BitmapImage bitmapImage;
                    bitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/tile2.png", UriKind.RelativeOrAbsolute));
                    Grid localBoard = FindName("ChessBoard") as Grid;
                    tileImage = new Image();
                    tileImage.Height = _iHeight * 0.99;
                    tileImage.Width = _iHeight * 0.99;
                    tileImage.Source = bitmapImage;
                    localBoard.Children.Add(tileImage);
                    tileImage.SetValue(Grid.RowProperty, (int)current.GetValue(Grid.RowProperty));
                    tileImage.SetValue(Grid.ColumnProperty, (int)current.GetValue(Grid.ColumnProperty));
                }
                else if (nearbybombs == 3)
                {
                    Image tileImage;
                    BitmapImage bitmapImage;
                    bitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/tile3.png", UriKind.RelativeOrAbsolute));
                    Grid localBoard = FindName("ChessBoard") as Grid;
                    tileImage = new Image();
                    tileImage.Height = _iHeight * 0.99;
                    tileImage.Width = _iHeight * 0.99;
                    tileImage.Source = bitmapImage;
                    localBoard.Children.Add(tileImage);
                    tileImage.SetValue(Grid.RowProperty, (int)current.GetValue(Grid.RowProperty));
                    tileImage.SetValue(Grid.ColumnProperty, (int)current.GetValue(Grid.ColumnProperty));
                }
                else if (nearbybombs == 4)
                {
                    Image tileImage;
                    BitmapImage bitmapImage;
                    bitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/tile4.png", UriKind.RelativeOrAbsolute));
                    Grid localBoard = FindName("ChessBoard") as Grid;
                    tileImage = new Image();
                    tileImage.Height = _iHeight * 0.99;
                    tileImage.Width = _iHeight * 0.99;
                    tileImage.Source = bitmapImage;
                    localBoard.Children.Add(tileImage);
                    tileImage.SetValue(Grid.RowProperty, (int)current.GetValue(Grid.RowProperty));
                    tileImage.SetValue(Grid.ColumnProperty, (int)current.GetValue(Grid.ColumnProperty));
                }
                else if (nearbybombs == 5)
                {
                    Image tileImage;
                    BitmapImage bitmapImage;
                    bitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/tile5.png", UriKind.RelativeOrAbsolute));
                    Grid localBoard = FindName("ChessBoard") as Grid;
                    tileImage = new Image();
                    tileImage.Height = _iHeight * 0.99;
                    tileImage.Width = _iHeight * 0.99;
                    tileImage.Source = bitmapImage;
                    localBoard.Children.Add(tileImage);
                    tileImage.SetValue(Grid.RowProperty, (int)current.GetValue(Grid.RowProperty));
                    tileImage.SetValue(Grid.ColumnProperty, (int)current.GetValue(Grid.ColumnProperty));
                }
                else if (nearbybombs == 6)
                {
                    Image tileImage;
                    BitmapImage bitmapImage;
                    bitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/tile6.png", UriKind.RelativeOrAbsolute));
                    Grid localBoard = FindName("ChessBoard") as Grid;
                    tileImage = new Image();
                    tileImage.Height = _iHeight * 0.99;
                    tileImage.Width = _iHeight * 0.99;
                    tileImage.Source = bitmapImage;
                    localBoard.Children.Add(tileImage);
                    tileImage.SetValue(Grid.RowProperty, (int)current.GetValue(Grid.RowProperty));
                    tileImage.SetValue(Grid.ColumnProperty, (int)current.GetValue(Grid.ColumnProperty));
                }
                else if (nearbybombs == 7)
                {
                    Image tileImage;
                    BitmapImage bitmapImage;
                    bitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/tile7.png", UriKind.RelativeOrAbsolute));
                    Grid localBoard = FindName("ChessBoard") as Grid;
                    tileImage = new Image();
                    tileImage.Height = _iHeight * 0.99;
                    tileImage.Width = _iHeight * 0.99;
                    tileImage.Source = bitmapImage;
                    localBoard.Children.Add(tileImage);
                    tileImage.SetValue(Grid.RowProperty, (int)current.GetValue(Grid.RowProperty));
                    tileImage.SetValue(Grid.ColumnProperty, (int)current.GetValue(Grid.ColumnProperty));
                }
                else if (nearbybombs == 8)
                {
                    Image tileImage;
                    BitmapImage bitmapImage;
                    bitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/tile8.png", UriKind.RelativeOrAbsolute));
                    Grid localBoard = FindName("ChessBoard") as Grid;
                    tileImage = new Image();
                    tileImage.Height = _iHeight * 0.99;
                    tileImage.Width = _iHeight * 0.99;
                    tileImage.Source = bitmapImage;
                    localBoard.Children.Add(tileImage);
                    tileImage.SetValue(Grid.RowProperty, (int)current.GetValue(Grid.RowProperty));
                    tileImage.SetValue(Grid.ColumnProperty, (int)current.GetValue(Grid.ColumnProperty));
                }
                #endregion
            }//else
        }
        private void createChessBoard()
        {
            try
            {
                rootGrid.Children.Remove(FindName("ChessBoard") as Grid);
            }
            catch {}

            Grid grdBoard = new Grid();
            grdBoard.Name = "ChessBoard";
            grdBoard.HorizontalAlignment = HorizontalAlignment.Center;
            grdBoard.VerticalAlignment = VerticalAlignment.Top;
            grdBoard.Height = _iHeight * _rows;
            grdBoard.Width = _iHeight * _rows;
            grdBoard.Background = new SolidColorBrush(Colors.Black);
            grdBoard.Margin = new Thickness(5);
            grdBoard.SetValue(Grid.RowProperty, 1);

            for (int i = 0; i < _rows; i++)
            {
                grdBoard.RowDefinitions.Add(new RowDefinition());
                grdBoard.ColumnDefinitions.Add(new ColumnDefinition());
            }

            rootGrid.Children.Add(grdBoard);
        }
    }
}
