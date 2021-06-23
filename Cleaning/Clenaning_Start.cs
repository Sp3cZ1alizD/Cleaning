using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cleaning
{
    public partial class Cleaning : Form
    {
        int global_time = 0;
        public Cleaning()
        {
            InitializeComponent();
            this.Temp_input.KeyPress += new KeyPressEventHandler(Temp_input_KeyPress);
            this.Volume_input.KeyPress += new KeyPressEventHandler(Volume_input_KeyPress);
            this.Cycles_input.KeyPress += new KeyPressEventHandler(Cycles_input_KeyPress);
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Start_button_Click(object sender, EventArgs e)
        {

            //Проверка на заполнености полей при нажатии
            if (Temp_input.Text == string.Empty | Volume_input.Text == string.Empty | Cycles_input.Text == string.Empty)
            {
                MessageBox.Show("Некотрые поля не заполнены",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Конвертирование значений для сравнения
                int Check_temp = Convert.ToInt32(Temp_input.Text);
                int Check_volume = Convert.ToInt32(Volume_input.Text);
                int Check_cycles = Convert.ToInt32(Cycles_input.Text);
                //Провека правильности значений путём сравнения
                if (Check_temp > 80 | Check_volume > 180 | Check_volume < 10 | Check_cycles == 0)
                {
                    //Вывод ошибки при неправильных значениях
                    MessageBox.Show("Введены недопустимые значения",
                                "Ошибка",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error,
                                 MessageBoxDefaultButton.Button1);
                }
                //Вывод предупреждения если общее время промывки занимает более 10 минут и температура превыашет 50 градусов
                else if (global_time >= 600 & Check_temp >= 50 & Check_temp <= 80)
                {
                    var result = MessageBox.Show("Время промывки занимает более 10 минут и температура превышает рекомендуемую 50 градусов, продолжить?",
                                 "Предупреждение",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning,
                                 MessageBoxDefaultButton.Button1);
                    //Если да, то переходит в следующее окно предупреждения необратимости процесса промывки
                    if (result == DialogResult.Yes)
                    {
                        var result_pod = MessageBox.Show("Программу промывки нельзя будет остановить, продолжить? ",
                                        "Предупреждение",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning,
                                         MessageBoxDefaultButton.Button1);
                        //Если да, то переходит в следующее окно
                        if (result_pod == DialogResult.Yes)
                        {
                            this.Hide();
                            Cleaning_Process cleaning_Process = new Cleaning_Process(Check_temp, Check_volume, Check_temp, global_time);
                            cleaning_Process.Show();
                        }
                    }
                }
                //Вывод предупреждения если температура больше 50
                else if (Check_temp >= 50 & Check_temp <= 80)
                {
                    var result = MessageBox.Show("Температура нагрева превышает рекомендуемую 50 градусов, продолжить?",
                                "Предупреждение",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1);
                    //Если да, то переходит в следующее окно предупреждения необратимости процесса промывки
                    if (result == DialogResult.Yes)
                    {
                        var result_pod = MessageBox.Show("Программу промывки нельзя будет остановить, продолжить? ",
                                        "Предупреждение",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning,
                                         MessageBoxDefaultButton.Button1);
                        //Если да, то переходит в следующее окно
                        if (result_pod == DialogResult.Yes)
                        {
                            this.Hide();
                            Cleaning_Process cleaning_Process = new Cleaning_Process(Check_temp, Check_volume, Check_temp, global_time);
                            cleaning_Process.Show();
                        }
                    }
                }
                //Вывод предупреждения если общее время промывки занимает более 10 минут
                else if (global_time >= 600)
                {
                    var result = MessageBox.Show("Время промывки занимает более 10 минут, продолжить?",
                                "Предупреждение",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1);
                    //Если да, то переходит в следующее окно предупреждения необратимости процесса промывки
                    if (result == DialogResult.Yes)
                    {
                        var result_pod = MessageBox.Show("Программу промывки нельзя будет остановить, продолжить? ",
                                        "Предупреждение",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning,
                                         MessageBoxDefaultButton.Button1);
                        //Если да, то переходит в следующее окно
                        if (result_pod == DialogResult.Yes)
                        {
                            this.Hide();
                            Cleaning_Process cleaning_Process = new Cleaning_Process(Check_temp, Check_volume, Check_temp, global_time);
                            cleaning_Process.Show();
                        }
                    }
                }
                //Если все значения верны, то переходит в следующее окно
                else
                {
                        var result_pod = MessageBox.Show("Программу промывки нельзя будет остановить, продолжить? ",
                                        "Предупреждение",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning,
                                         MessageBoxDefaultButton.Button1);
                    //Если да, то переходит в следующее окно
                    if (result_pod == DialogResult.Yes)
                    {
                        this.Hide();
                        Cleaning_Process cleaning_Process = new Cleaning_Process(Check_temp, Check_volume, Check_temp, global_time);
                        cleaning_Process.Show();
                    }
                }
            }
        }
        //Запрет на ввод букв в Temp_Textbox
        private void Temp_input_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
        //Запрет на ввод букв в Voulume_Textbox
        private void Volume_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
        //Запрет на ввод букв в Cycles_Textbox
        private void Cycles_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
        //Очистка ввода и времени
        private void Drop_button_Click(object sender, EventArgs e)
        {
            Temp_input.Text = string.Empty;
            Volume_input.Text = string.Empty;
            Cycles_input.Text = string.Empty;
            Time_label.Text = "Время промывки";
        }
        //Расчёт времени промывки при изменеии количества циклов
        private void Cycles_input_TextChanged(object sender, EventArgs e)
        {
            //Игнорирование пустых полей при записи в переменные
            if (Temp_input.Text == string.Empty | Volume_input.Text == string.Empty | Cycles_input.Text == string.Empty)
            {

            }
            else
            {
                //Расчёт времени при введенных даннных
                float Volume = Convert.ToInt32(Volume_input.Text);
                int Cycles = Convert.ToInt32(Cycles_input.Text);
                float Time = Volume / 100 * 60 * Cycles;
                global_time = Convert.ToInt32(Time);
                var ts = TimeSpan.FromSeconds(Time);
                this.Time_label.Text = "Время промывки " + ts.Minutes + " мин. " + ts.Seconds + " сек.";
            }
        }
        //Расчёт времени промывки при изменеии количества промываемой жидкости
        private void Volume_input_TextChanged(object sender, EventArgs e)
        {
            //Игнорирование пустых полей при записи в переменные
            if (Temp_input.Text == string.Empty | Volume_input.Text == string.Empty | Cycles_input.Text == string.Empty)
            {

            }
            else
            {
                //Расчёт времени при введенных даннных
                float Volume = Convert.ToInt32(Volume_input.Text);
                int Cycles = Convert.ToInt32(Cycles_input.Text);
                float Time = Volume / 100 * 60 * Cycles;
                global_time = Convert.ToInt32(Time);
                var ts = TimeSpan.FromSeconds(Time);
                this.Time_label.Text = "Время промывки " + ts.Minutes + " мин. " + ts.Seconds + " сек.";
            }
        }
    }
}