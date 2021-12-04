using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Linq;

namespace App1calcu
{
    //המחשבון עובד עם פעולה אחת בין מספרים בכל פעם
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView txt1, txt2;
        Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btnp, btnm, btne, btnx, btnc, btns, btnt, btnd, btnh, btnf,btnac;

        protected override void OnCreate(Bundle savedInstanceState)
        {
           
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btn1 = FindViewById<Button>(Resource.Id.btn1);
            btn2= FindViewById<Button>(Resource.Id.btn2);
            btn3 = FindViewById<Button>(Resource.Id.btn3);
            btn4= FindViewById<Button>(Resource.Id.btn4);
            btn5 = FindViewById<Button>(Resource.Id.btn5);
            btn6 = FindViewById<Button>(Resource.Id.btn6);
            btn7 = FindViewById<Button>(Resource.Id.btn7);
            btn8 = FindViewById<Button>(Resource.Id.btn8);
            btn9 = FindViewById<Button>(Resource.Id.btn9);
            btnp = FindViewById<Button>(Resource.Id.btnp);
            btnm = FindViewById<Button>(Resource.Id.btnm);
            btne = FindViewById<Button>(Resource.Id.btne);
            btnac = FindViewById<Button>(Resource.Id.btnac);
            btnx = FindViewById<Button>(Resource.Id.btnx);
            btnh = FindViewById<Button>(Resource.Id.btnh);
            btnd = FindViewById<Button>(Resource.Id.btnd);
            btnf = FindViewById<Button>(Resource.Id.btnf);
            btnc = FindViewById<Button>(Resource.Id.btnc);
            btns = FindViewById<Button>(Resource.Id.btns);
            btnt = FindViewById<Button>(Resource.Id.btnt);



            txt1 = FindViewById<TextView>(Resource.Id.txt1);
            txt2= FindViewById<TextView>(Resource.Id.txt2);


            btn1.Click += Onbuttonclicked;
            btn2.Click += Onbuttonclicked;
            btn3.Click += Onbuttonclicked;
            btn4.Click += Onbuttonclicked;
            btn5.Click += Onbuttonclicked;
            btn6.Click += Onbuttonclicked;
            btn7.Click += Onbuttonclicked;
            btn8.Click += Onbuttonclicked;
            btn9.Click += Onbuttonclicked;
            btnp.Click += Onbuttonclicked;
            btnm.Click += Onbuttonclicked;
            btne.Click += Onbuttonclicked;
            btnac.Click += Onbuttonclicked;
            btnx.Click += Onbuttonclicked;
            btnh.Click += Onbuttonclicked;
            btnd.Click += Onbuttonclicked;
            btnf.Click += Onbuttonclicked;
            btnc.Click += Onbuttonclicked;
            btns.Click += Onbuttonclicked;
            btnt.Click += Onbuttonclicked;





        }
        int dco=0;
        string st2;
        string op;
        double answer = 0;
        string[] numbs= { "1", "1", "1", "1", "1", "1", "1", "1", "1", "1" };
        


        public void Onbuttonclicked(object sender,System.EventArgs e)
        {
            
            
            Button btn = (Button)sender;
            if (btnac == btn)
            {
                txt1.Text ="";
                txt2.Text = "";
                answer = 0;

            }
            if (btn1 == btn)
            {
                txt1.Text = txt1.Text+"1";
            }
            if (btn2 == btn)
            {
                txt1.Text = txt1.Text + "2";
            }
            if (btn3 == btn)
            {
                txt1.Text = txt1.Text + "3";
            }
            if (btn4 == btn)
            {
                txt1.Text = txt1.Text + "4";
            }
            if (btn5 == btn)
            {
                txt1.Text = txt1.Text + "5";
            }
            if (btn6 == btn)
            {
                txt1.Text = txt1.Text + "6";
            }
            if (btn7 == btn)
            {
                txt1.Text = txt1.Text + "7";
            }
            if (btn8 == btn)
            {
                txt1.Text = txt1.Text + "8";
            }
            if (btn9 == btn)
            {
                txt1.Text = txt1.Text + "9";
            }
            if (btnf == btn)
            {
                txt1.Text = txt1.Text + "0";
            }

            if (btnd == btn && dco==0)
            {
                txt1.Text = txt1.Text + ".";
                dco++;
            }
            if (btnp == btn)// פיצול של המחרוזת אם יש פעולה כלשהי בכל כפתור בודק פעולה אחרת למערך, בכל איבר במערך מספר בתרגיל
            {
                dco = 0;
                txt1.Text += "+";
                st2 = txt1.Text + "+";
                numbs = st2.Split("+");
                op = "+";
                

            }
            if (btnm == btn)
            {

                dco = 0;
                txt1.Text += "-";
                st2 = txt1.Text;
                numbs = st2.Split("-");
                op = "-";
            }
            if (btnx == btn)
            {
                dco = 0;
                txt1.Text += "x";
                st2 = txt1.Text;
                numbs = st2.Split("x");
                op = "x";
            }
            if (btnh == btn)
            {
                dco = 0;
                txt1.Text += "/";
                st2 = txt1.Text;
                numbs = st2.Split("/");
                op = "/";
            }
            if (btnc == btn)
            {
                dco = 0;
                st2 = txt1.Text;
                txt1.Text += "COS";
                op = "COS";
            }
            if (btns == btn)
            {
                dco = 0;
                st2 = txt1.Text;
                txt1.Text += "SIN";
                op = "SIN";
            }
            if (btnt == btn)
            {
                dco = 0;
                st2 = txt1.Text;
                txt1.Text += "TAN";
                op = "TAN";
            }


            if (btne == btn)// מציאת המספר האחרון בתרגיל על ידי פיצול והמרה לטיפוס דאבל
            {
                dco = 0;
                double an4 = 0;
                if (txt1.Text.Contains('+') || txt1.Text.Contains('-') || txt1.Text.Contains('x') || txt1.Text.Contains('/') )
                {
                     an4 = Convert.ToDouble(txt1.Text.Split('+', '-', 'x', '/').Last());
                }
                
                double an1 = Convert.ToDouble(numbs[0]);
                answer = an1;
             

                if (op == "+")
                {
                    
                    answer = an1 + an4;
                    txt2.Text = Convert.ToString(answer);
                    txt1.Text = Convert.ToString(answer);
                }
                if (op == "-") {
                    answer = an1 - an4;
                    txt2.Text = Convert.ToString(answer);
                    txt1.Text = Convert.ToString(answer);
                }
                if (op == "x")
                {
                    answer = an1 * an4;
                    txt2.Text = Convert.ToString(answer);
                    txt1.Text = Convert.ToString(answer);
                }
                if (op == "/")
                {
                    answer = an1 / an4;
                    txt2.Text = Convert.ToString(answer);
                    txt1.Text = Convert.ToString(answer);
                }
                if (op == "COS")//המרה של המספר ממעלות לרדיאן וחישוב טריגונומטרי
                {
                   
                    st2 = txt1.Text;
                    numbs = st2.Split("COS");
                    double a = Convert.ToDouble(numbs[0]);
                    a = a * Math.PI / 180;
                    
                    answer = Math.Cos(a);
                    if (answer<0.001)
                    {
                        txt2.Text = "0";
                        txt1.Text = "0";
                    }
                    else
                    {
                        txt2.Text = Convert.ToString(answer);
                        txt1.Text = Convert.ToString(answer);
                    }
                    
                }
                if (op == "SIN")
                {

                    st2 = txt1.Text;
                    numbs = st2.Split("SIN");
                    double a = Convert.ToDouble(numbs[0]);
                    a = a * Math.PI / 180;

                    answer = Math.Sin(a);
                    if (answer < 0.001)
                    {
                        txt2.Text = "0";
                        txt1.Text = "0";
                    }
                    else
                    {
                        txt2.Text = Convert.ToString(answer);
                        txt1.Text = Convert.ToString(answer);
                    }

                }
                if (op == "TAN")
                {

                    st2 = txt1.Text;
                    numbs = st2.Split("TAN");
                    double a = Convert.ToDouble(numbs[0]);
                    a = a * Math.PI / 180;

                    answer = Math.Tan(a);
                    if (answer < 0.001)
                    {
                        txt2.Text = "0";
                        txt1.Text = "0";
                    }
                    else
                    {
                        txt2.Text = Convert.ToString(answer);
                        txt1.Text = Convert.ToString(answer);
                    }

                }


            }

            




        }
        
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
       
    }
}


   