using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace DataInsertion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProject1Data_Click(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();

            SalesAndShippingDWEntities context = new SalesAndShippingDWEntities();

            DateTime dt = dateTimePicker1.Value;
            while (dt < DateTime.Now)
            {
                int day = pc.GetDayOfMonth(dt);
                int month = pc.GetMonth(dt);
                int year = pc.GetYear(dt);
                DayOfWeek dayOfTheWeek = pc.GetDayOfWeek(dt);
                int quarter = GetQuarter(month);

                DimTime time = new DimTime()
                {
                    MiladiDate = dt,
                    PersianDate = year.ToString("0000") + "/" + month.ToString("00") + "/" + day.ToString("00"),
                    Day = day,
                    DayOfTheWeek = (int)pc.GetDayOfWeek(dt),
                    DayOfTheWeekName = dayOfTheWeek.ToString(),
                    DayOfTheWeekPersianName = GetDyaofTheWeekPersianName(dayOfTheWeek),
                    Month = month,
                    MonthName = GetMonthName(month),
                    Quarter = quarter,
                    QuarterName = GetQuarterName(quarter),
                    Year = year,
                };
                context.DimTimes.AddObject(time);

                dt = dt.AddDays(1);
            }

            context.SaveChanges();
            MessageBox.Show("ورود اطلاعات با موفقیت انجام شد");
        }

        private string GetMonthName(int month)
        {
            string monthName = "";
            switch (month)
            {
                case 1:
                    monthName = "فروردین";
                    break;
                case 2:
                    monthName = "اردیبهشت";
                    break;
                case 3:
                    monthName = "خرداد";
                    break;
                case 4:
                    monthName = "تیر";
                    break;
                case 5:
                    monthName = "مرداد";
                    break;
                case 6:
                    monthName = "شهریور";
                    break;
                case 7:
                    monthName = "مهر";
                    break;
                case 8:
                    monthName = "آبان";
                    break;
                case 9:
                    monthName = "آذر";
                    break;
                case 10:
                    monthName = "دی";
                    break;
                case 11:
                    monthName = "بهمن";
                    break;
                case 12:
                    monthName = "اسفند";
                    break;
                default:
                    break;
            }

            return monthName;
        }

        private string GetQuarterName(int quarter)
        {
            string quarterName = "";
            switch (quarter)
            {
                case 1:
                    quarterName = "بهار";
                    break;
                case 2:
                    quarterName = "تابستان";
                    break;
                case 3:
                    quarterName = "پاییز";
                    break;
                case 4:
                    quarterName = "زمستان";
                    break;
                default:
                    break;
            }

            return quarterName;
        }

        private int GetQuarter(int month)
        {
            int quarter = 0;
            if (month > 0 && month <= 3)
            {
                quarter = 1;
            }
            else if (month > 3 && month <= 6)
            {
                quarter = 2;
            }
            else if (month > 6 && month <= 9)
            {
                quarter = 3;
            }
            else if (month > 9 && month <= 12)
            {
                quarter = 4;
            }

            return quarter;
        }


        private string GetDyaofTheWeekPersianName(DayOfWeek dayOfWeek)
        {
            string dayOfWeekName = "";

            switch (dayOfWeek)
            {
                case DayOfWeek.Friday:
                    dayOfWeekName = "جمعه";
                    break;
                case DayOfWeek.Monday:
                    dayOfWeekName = "دوشنبه";
                    break;
                case DayOfWeek.Saturday:
                    dayOfWeekName = "شنبه";
                    break;
                case DayOfWeek.Sunday:
                    dayOfWeekName = "یکشنبه";
                    break;
                case DayOfWeek.Thursday:
                    dayOfWeekName = "پنجشنبه";
                    break;
                case DayOfWeek.Tuesday:
                    dayOfWeekName = "سه شنبه";
                    break;
                case DayOfWeek.Wednesday:
                    dayOfWeekName = "چهارشنبه";
                    break;
                default:
                    break;
            }

            return dayOfWeekName;
        }
    }
}
