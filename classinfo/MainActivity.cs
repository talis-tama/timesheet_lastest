using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace classinfo
{
    [Activity(Label = "時間割", MainLauncher = true)]
    public class MainActivity : Activity
    {
        int weekNo = 0, hour = 0, min = 0, showNo = 0;
        TextView textView2, textView4, textView5, textView6, textView7, textView8, textView9, textView10, textView11, textView12, textView14, textView17, textView18, textView20, textView21, textView23, textView24, textView26, textView27, textView29, textView30;
        TextClock textClock2;
        Button button1, button2;
        DateTime tim;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            Initilizing();
            TimePicker();
            DataReader_week();
            TimeChecker();
        }
        void Initilizing()
        {
            tim = new DateTime();
            textView2 = (TextView)FindViewById(Resource.Id.textView2);
            textView4 = (TextView)FindViewById(Resource.Id.textView4);
            textView5 = (TextView)FindViewById(Resource.Id.textView5);
            textView6 = (TextView)FindViewById(Resource.Id.textView6);
            textView7 = (TextView)FindViewById(Resource.Id.textView7);
            textView8 = (TextView)FindViewById(Resource.Id.textView8);
            textView9 = (TextView)FindViewById(Resource.Id.textView9);
            textView10 = (TextView)FindViewById(Resource.Id.textView10);
            textView11 = (TextView)FindViewById(Resource.Id.textView11);
            textView12 = (TextView)FindViewById(Resource.Id.textView12);
            textView14 = (TextView)FindViewById(Resource.Id.textView14);
            textView17 = (TextView)FindViewById(Resource.Id.textView17);
            textView18 = (TextView)FindViewById(Resource.Id.textView18);
            textView20 = (TextView)FindViewById(Resource.Id.textView20);
            textView21 = (TextView)FindViewById(Resource.Id.textView21);
            textView23 = (TextView)FindViewById(Resource.Id.textView23);
            textView24 = (TextView)FindViewById(Resource.Id.textView24);
            textView26 = (TextView)FindViewById(Resource.Id.textView26);
            textView27 = (TextView)FindViewById(Resource.Id.textView27);
            textView29 = (TextView)FindViewById(Resource.Id.textView29);
            textView30 = (TextView)FindViewById(Resource.Id.textView30);
            textClock2 = (TextClock)FindViewById(Resource.Id.textClock2);
            button1 = (Button)FindViewById(Resource.Id.button1);
            button2 = (Button)FindViewById(Resource.Id.button2);
            textClock2.TextChanged += TextClock2_TextChanged;
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }
        void TextClock2_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            if (textClock2.Text == ")00:00")
            {
                TimePicker();
                Classinfo_first();
            }
            else if (textClock2.Text == ")09:20") { Classinfo_second(); }
            else if (textClock2.Text == ")11:00") { Classinfo_third(); }
            else if (textClock2.Text == ")13:20") { Classinfo_fourth(); }
            else if (textClock2.Text == ")15:00") { Classinfo_fifth(); }
            else if (textClock2.Text == ")16:40") { Classinfo_end(); }
        }
        void TimePicker()
        {
            tim = DateTime.Now;
            textView2.Text = tim.ToString("ddd");
            weekNo = (int)tim.DayOfWeek;
            showNo = (int)tim.DayOfWeek;
        }
        void TimeChecker()
        {
            hour = tim.Hour;
            min = tim.Minute;
            if (hour <= 8 || hour == 9 && min <= 19) { Classinfo_first(); }
            else if (hour == 9 && min >= 20 || hour == 10) { Classinfo_second(); }
            else if (hour >= 11 && hour <= 12 || hour == 13 && min <= 19) { Classinfo_third(); }
            else if (hour == 13 && min >= 20 || hour == 14) { Classinfo_fourth(); }
            else if (hour == 15 || hour == 16 && min <= 39) { Classinfo_fifth(); }
            else { Classinfo_end(); }
        }
        void DataReader_week()
        {
            if (weekNo == 0) { Classinfo_sunday(); }
            else if (weekNo == 1) { Classinfo_monday(); }
            else if (weekNo == 2) { Classinfo_tuesday(); }
            else if (weekNo == 3) { Classinfo_wednesday(); }
            else if (weekNo == 4) { Classinfo_thrsday(); }
            else if (weekNo == 5) { Classinfo_fryday(); }
            else if (weekNo == 6) { Classinfo_saturday(); }
        }
        void Classinfo_first()
        {
            if (weekNo == 1)
            {
                textView7.Text = "健康・スポーツ実習II";
                textView8.Text = "13:20～14:50";
                textView11.Text = "井上 望";
                textView12.Text = "----";
            }
            else if (weekNo == 2)
            {
                textView7.Text = "英語IB";
                textView8.Text = "11:00～12:30";
                textView11.Text = "石川 真知子";
                textView12.Text = "7402";
            }
            else if (weekNo == 3)
            {
                textView7.Text = "英語IIB";
                textView8.Text = "11:00～12:30";
                textView11.Text = "T.Rucynsky";
                textView12.Text = "3407";
            }
            else if (weekNo == 4)
            {
                textView7.Text = "プレゼミナールII";
                textView8.Text = "9:20～10:50";
                textView11.Text = "今村 庸一";
                textView12.Text = "2107";
            }
            else if (weekNo == 5)
            {
                textView7.Text = "プログラミング入門演習";
                textView8.Text = "9:20～10:50";
                textView11.Text = "寺嶋　秀美";
                textView12.Text = "7501";
            }
            else if (weekNo == 6) { Classinfo_end(); }
        }
        void Classinfo_second()
        {
            if (weekNo == 1)
            {
                textView7.Text = "健康・スポーツ実習II";
                textView8.Text = "13:20～14:50";
                textView11.Text = "井上 望";
                textView12.Text = "----";
            }
            else if (weekNo == 2)
            {
                textView7.Text = "英語IB";
                textView8.Text = "11:00～12:30";
                textView11.Text = "石川 真知子";
                textView12.Text = "7402";
            }
            else if (weekNo == 3)
            {
                textView7.Text = "英語IIB";
                textView8.Text = "11:00～12:30";
                textView11.Text = "T.Rucynsky";
                textView12.Text = "3407";
            }
            else if (weekNo == 4)
            {
                textView7.Text = "経済学II";
                textView8.Text = "11:00～12:30";
                textView11.Text = "佐川 和彦";
                textView12.Text = "7002";
            }
            else if (weekNo == 5)
            {
                textView7.Text = "中国語と文化";
                textView8.Text = "11:00～12:30";
                textView11.Text = "葉 紅";
                textView12.Text = "グローバル教育センター";
            }
            else if (weekNo == 6) { Classinfo_end(); }
        }
        void Classinfo_third()
        {
            if (weekNo == 1)
            {
                textView7.Text = "健康・スポーツ実習II";
                textView8.Text = "13:20～14:50";
                textView11.Text = "井上 望";
                textView12.Text = "----";
            }
            else if (weekNo == 2)
            {
                textView7.Text = "英語演習II";
                textView8.Text = "13:20～14:50";
                textView11.Text = "T.Rucynski";
                textView12.Text = "3407";
            }
            else if (weekNo == 3)
            {
                textView7.Text = "中国語II";
                textView8.Text = "13:20～14:50";
                textView11.Text = "蒋 彧亭";
                textView12.Text = "3302";
            }
            else if (weekNo == 4) { Classinfo_end(); }
            else if (weekNo == 5)
            {
                textView7.Text = "コンピュータ・リテラシーII";
                textView8.Text = "13:20～14:50";
                textView11.Text = "太田 康友";
                textView12.Text = "3504";
            }
            else if (weekNo == 6) { Classinfo_end(); }
        }
        void Classinfo_fourth()
        {
            if (weekNo == 1)
            {
                textView7.Text = "中国語I";
                textView8.Text = "15:00～16:30";
                textView11.Text = "河合 史恵";
                textView12.Text = "7403";
            }
            else if (weekNo == 2)
            {
                textView7.Text = "キャリア基礎II";
                textView8.Text = "15:00～16:30";
                textView11.Text = "小山 知子";
                textView12.Text = "3405";
            }
            else if (weekNo == 3)
            {
                textView7.Text = "記録情報概論";
                textView8.Text = "15:00～16:30";
                textView11.Text = "村越 一哲";
                textView12.Text = "7201";
            }
            else if (weekNo == 4) { Classinfo_end(); }
            else if (weekNo == 5) { Classinfo_end(); }
            else if (weekNo == 6) { Classinfo_end(); }
        }
        void Classinfo_fifth()
        {
            if (weekNo == 1) { Classinfo_end(); }
            else if (weekNo == 2) { Classinfo_end(); }
            else if (weekNo == 3) { Classinfo_end(); }
            else if (weekNo == 4) { Classinfo_end(); }
            else if (weekNo == 5) { Classinfo_end(); }
            else if (weekNo == 6) { Classinfo_end(); }
        }
        void Classinfo_end()
        {
            textView4.Text = "";
            textView5.Text = "本日の予定";
            textView6.Text = "";
            textView7.Text = "本日の授業はすべて終了しました";
            textView8.Text = "";
            textView9.Text = "";
            textView10.Text = "";
            textView11.Text = "";
            textView12.Text = "";
            if (weekNo == 1)
            {
                Classinfo_tuesday();
                textView14.Text = "火曜日の予定";
            }
            else if (weekNo == 2)
            {
                Classinfo_wednesday();
                textView14.Text = "水曜日の予定";
            }
            else if (weekNo == 3)
            {
                Classinfo_thrsday();
                textView14.Text = "木曜日の予定";
            }
            else if (weekNo == 4)
            {
                Classinfo_fryday();
                textView14.Text = "金曜日の予定";
            }
            else if (weekNo == 5)
            {
                Classinfo_saturday();
                textView14.Text = "土曜日の予定";
            }
            else if (weekNo == 6)
            {
                Classinfo_monday();
                textView14.Text = "月曜日の予定";
                showNo = 0;
            }
            showNo++;
        }
        void Classinfo_sunday()
        {
            textView4.Text = "";
            textView5.Text = "本日の予定";
            textView6.Text = "";
            textView7.Text = "本日は休日です";
            textView8.Text = "";
            textView9.Text = "";
            textView10.Text = "";
            textView11.Text = "";
            textView12.Text = "";
            textView14.Text = "月曜日の予定";
            showNo++;
            Classinfo_monday();
        }
        void Classinfo_monday()
        {
            textView17.Text = "空き";
            textView18.Text = "----";
            textView20.Text = "空き";
            textView21.Text = "----";
            textView23.Text = "健康・スポーツ実習II";
            textView24.Text = "----";
            textView26.Text = "中国語IB";
            textView27.Text = "7403";
            textView29.Text = "空き";
            textView30.Text = "----";
        }
        void Classinfo_tuesday()
        {
            textView17.Text = "空き";
            textView18.Text = "----";
            textView20.Text = "英語IB";
            textView21.Text = "7402";
            textView23.Text = "英語演習II";
            textView24.Text = "3407";
            textView26.Text = "キャリア基礎";
            textView27.Text = "3405";
            textView29.Text = "空き";
            textView30.Text = "----";
        }
        void Classinfo_wednesday()
        {
            textView17.Text = "空き";
            textView18.Text = "----";
            textView20.Text = "英語IIB";
            textView21.Text = "3407";
            textView23.Text = "中国語IIB";
            textView24.Text = "3302";
            textView26.Text = "記録情報概論";
            textView27.Text = "7201";
            textView29.Text = "空き";
            textView30.Text = "----";
        }
        void Classinfo_thrsday()
        {
            textView17.Text = "プレゼミナールII";
            textView18.Text = "2107";
            textView20.Text = "経済学II";
            textView21.Text = "7002";
            textView23.Text = "空き";
            textView24.Text = "----";
            textView26.Text = "空き";
            textView27.Text = "----";
            textView29.Text = "空き";
            textView30.Text = "----";
        }
        void Classinfo_fryday()
        {
            textView17.Text = "プログラミング入門演習";
            textView18.Text = "7501";
            textView20.Text = "中国語と文化";
            textView21.Text = "グローバル教育センター";
            textView23.Text = "コンピュータ・リテラシーII";
            textView24.Text = "3504";
            textView26.Text = "空き";
            textView27.Text = "----";
            textView29.Text = "空き";
            textView30.Text = "----";
        }
        void Classinfo_saturday()
        {
            textView17.Text = "空き";
            textView18.Text = "----";
            textView20.Text = "空き";
            textView21.Text = "----";
            textView23.Text = "空き";
            textView24.Text = "----";
            textView26.Text = "空き";
            textView27.Text = "----";
            textView29.Text = "空き";
            textView30.Text = "----";
        }
        void Button1_Click(object sender, EventArgs e)
        {
            showNo--;
            if (showNo == 0) { showNo = 6; }
            Classinfo_reflesh();
        }
        void Button2_Click(object sender, EventArgs e)
        {
            showNo++;
            if (showNo == 7) { showNo = 1; }
            Classinfo_reflesh();
        }
        void Classinfo_reflesh()
        {
            switch (showNo)
            {
                case 1:
                    textView14.Text = "月曜日の予定";
                    Classinfo_monday();
                    break;
                case 2:
                    textView14.Text = "火曜日の予定";
                    Classinfo_tuesday();
                    break;
                case 3:
                    textView14.Text = "水曜日の予定";
                    Classinfo_wednesday();
                    break;
                case 4:
                    textView14.Text = "木曜日の予定";
                    Classinfo_thrsday();
                    break;
                case 5:
                    textView14.Text = "金曜日の予定";
                    Classinfo_fryday();
                    break;
                case 6:
                    textView14.Text = "土曜日の予定";
                    Classinfo_saturday();
                    break;
            }
        }
    }
}

