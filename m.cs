using System;
using System.Globalization;

public class m
{
	private const int m_a = 3;

	private const int m_b = 3;

	private const int c = 4;

	private const int d = 5;

	private const int e = 7;

	private const int f = 3;

	private const int g = 5;

	private const int h = 4;

	private const int i = 3;

	private const int j = 5;

	private u k;

	private l l;

	public string[] mm;

	public int n;

	public int[] o = new int[10];

	public int p;

	public int q;

	public bool[] r = new bool[10];

	public string[] s;

	public string[] t;

	public string[] u;

	public string[] v;

	public string[] w;

	public string[] x;

	public string[] y;

	public string[] z;

	public string[] aa;

	public string[] ab;

	public m(u A_0)
	{
		k = A_0;
		a();
	}

	private void a()
	{
		Random random = new Random();
		p = random.Next(100);
		q = random.Next(100);
		for (int num = 0; num < o.Length; num++)
		{
			o[num] = p;
		}
		string a_ = "Main_Time_" + random.Next(0, 4).ToString(CultureInfo.InvariantCulture);
		a(a_);
		a_ = "Main_Date_" + random.Next(0, 4).ToString(CultureInfo.InvariantCulture);
		a(a_);
		a_ = "Main_Other_" + random.Next(0, 5).ToString(CultureInfo.InvariantCulture);
		a(a_);
		string text = a_;
		a_ = "Advanced_OC_" + random.Next(0, 6).ToString(CultureInfo.InvariantCulture);
		a(a_);
		a_ = "Advanced_JF_" + random.Next(0, 8).ToString(CultureInfo.InvariantCulture);
		a(a_);
		a_ = "Advanced_USB_" + random.Next(0, 4).ToString(CultureInfo.InvariantCulture);
		a(a_);
		a_ = "Advanced_Onb_" + random.Next(0, 6).ToString(CultureInfo.InvariantCulture);
		a(a_);
		a_ = "Power_" + random.Next(0, 5).ToString(CultureInfo.InvariantCulture);
		a(a_);
		a_ = "Power_Other_" + random.Next(0, 4).ToString(CultureInfo.InvariantCulture);
		a(a_);
		a_ = ((!(text == "Main_Other_2") && !(text == "Main_Other_4")) ? ("Boot_" + random.Next(0, 6).ToString(CultureInfo.InvariantCulture)) : ("Boot_" + random.Next(0, 4).ToString(CultureInfo.InvariantCulture)));
		a(a_);
	}

	private void a(string A_0)
	{
		switch (A_0)
		{
		case "Main_Time_0":
			s = new string[7] { "Установите системное время компьютера в положение: 06:10:00 (HH:MM:SS).", "0", "06", "1", "10", "2", "00" };
			break;
		case "Main_Time_1":
			s = new string[7] { "Установите системное время компьютера в положение: 10:00:00 (HH:MM:SS).", "0", "10", "1", "00", "2", "00" };
			break;
		case "Main_Time_2":
			s = new string[7] { "Установите системное время компьютера в положение: 23:59:59 (HH:MM:SS).", "0", "23", "1", "59", "2", "59" };
			break;
		case "Main_Time_3":
			s = new string[7] { "Установите системное время компьютера в положение: 00:00:00 (HH:MM:SS).", "0", "00", "1", "00", "2", "00" };
			break;
		case "Main_Date_0":
			t = new string[7] { "Установите дату компьютера в положение: 11 сентября 2001 г.", "3", "09", "4", "11", "5", "2001" };
			break;
		case "Main_Date_1":
			t = new string[7] { "Установите дату компьютера в положение: 1 февраля 2003 г.", "3", "02", "4", "01", "5", "2003" };
			break;
		case "Main_Date_2":
			t = new string[7] { "Установите дату компьютера в положение: 10 октября 2005 г.", "3", "10", "4", "10", "5", "2005" };
			break;
		case "Main_Date_3":
			t = new string[7] { "Установите дату компьютера в положение: 1 апреля 2009 г.", "3", "04", "4", "01", "5", "2009" };
			break;
		case "Main_Other_0":
			u = new string[3] { "Отключите Floppy-дисковод.", "6", "Disabled" };
			break;
		case "Main_Other_1":
			u = new string[3] { "Установите длительность задержки перед проведением опроса устройств, подключенных к SATA портам, равную 20 секундам.", "32", "20" };
			break;
		case "Main_Other_2":
			u = new string[3] { "Отключите жесткий диск Hitachi HDT725032VLA360 от порта SATA 1 (для этого необходимо изменить тип устройства).", "8", "Not Installed" };
			break;
		case "Main_Other_3":
			u = new string[5] { "Принудительно активируйте S.M.A.R.T. диагностику жесткого диска Hitachi HDT725032VLA360.", "8", "Auto", "13", "Enabled" };
			break;
		case "Main_Other_4":
			u = new string[3] { "Отключите жесткий диск Seagate ST3250824AS от порта SATA 3 (для этого необходимо изменить тип устройства).", "22", "Not Installed" };
			break;
		case "Advanced_OC_0":
			v = new string[5] { "Уменьшите частоту центрального процессора до 1596 MHz, при этом частота системной шины должна остаться неизменной, т.е. равной 266 MHz.", "36", "06.0", "38", "266" };
			break;
		case "Advanced_OC_1":
			v = new string[5] { "Уменьшите частоту центрального процессора до 1862 MHz, при этом частота системной шины должна остаться неизменной, т.е. равной 266 MHz.", "36", "07.0", "38", "266" };
			break;
		case "Advanced_OC_2":
			v = new string[5] { "Уменьшите частоту центрального процессора до 2261 MHz, при этом частота системной шины должна остаться неизменной, т.е. равной 266 MHz.", "36", "08.5", "38", "266" };
			break;
		case "Advanced_OC_3":
			v = new string[7] { "Увеличьте частоту центрального процессора до 2850 MHz, при этом множитель процессора должен остаться неизменным.", "33", "Manual", "38", "300", "140", "9.5" };
			break;
		case "Advanced_OC_4":
			v = new string[7] { "Увеличьте частоту центрального процессора до 3040 MHz, при этом множитель процессора должен остаться неизменным.", "33", "Manual", "38", "320", "140", "9.5" };
			break;
		case "Advanced_OC_5":
			v = new string[7] { "Увеличьте частоту центрального процессора до 3325 MHz, при этом множитель процессора должен остаться неизменным.", "33", "Manual", "38", "350", "140", "9.5" };
			break;
		case "Advanced_JF_0":
			w = new string[11]
			{
				"Установите 4 основных тайминга (задержки) оперативной памяти в положение 4-4-4-14 DRAM Clocks (CAS# Latency, RAS# to CAS# Delay, RAS# PRE Time и RAS# ACT Time соответственно).", "42", "Manual", "44", "4 DRAM Clocks", "45", "4 DRAM Clocks", "46", "4 DRAM Clocks", "47",
				"14 DRAM Clocks"
			};
			break;
		case "Advanced_JF_1":
			w = new string[11]
			{
				"Установите 4 основных тайминга (задержки) оперативной памяти в положение 4-5-5-14 DRAM Clocks (CAS# Latency, RAS# to CAS# Delay, RAS# PRE Time и RAS# ACT Time соответственно).", "42", "Manual", "44", "4 DRAM Clocks", "45", "5 DRAM Clocks", "46", "5 DRAM Clocks", "47",
				"14 DRAM Clocks"
			};
			break;
		case "Advanced_JF_2":
			w = new string[7] { "Установите 2 тайминга (задержки) оперативной памяти в положение: RAS# to RAS# Delay = 5 DRAM Clocks, WRITE Recovery Time = 8 DRAM Clocks.", "42", "Manual", "48", "5 DRAM Clocks", "50", "8 DRAM Clocks" };
			break;
		case "Advanced_JF_3":
			w = new string[7] { "Установите 2 тайминга (задержки) оперативной памяти в положение: WRITE to READ Delay = 4 DRAM Clocks, READ to PRE Time = 4 DRAM Clocks.", "42", "Manual", "51", "4 DRAM Clocks", "52", "4 DRAM Clocks" };
			break;
		case "Advanced_JF_4":
			w = new string[3] { "Повысьте напряжение питания ядра процессора до 1,4 Вольта.", "56", "1.4000V" };
			break;
		case "Advanced_JF_5":
			w = new string[3] { "Повысьте напряжение питания модулей оперативной памяти до 2,1 Вольта.", "59", "2.10V" };
			break;
		case "Advanced_JF_6":
			w = new string[3] { "Повысьте напряжение питания северного моста до 1,55 Вольта.", "60", "1.55V" };
			break;
		case "Advanced_JF_7":
			w = new string[3] { "Отключите программно-аппаратный механизм защиты процессора от переполнения буфера.", "77", "Disabled" };
			break;
		case "Advanced_USB_0":
			x = new string[3] { "Сделайте невозможным использование USB-портов компьютера.", "67", "Disabled" };
			break;
		case "Advanced_USB_1":
			x = new string[3] { "Запретите использование USB-устройств на компьютере.", "67", "Disabled" };
			break;
		case "Advanced_USB_2":
			x = new string[5] { "Отключите поддержку шиной USB протокола USB 2.0.", "67", "Enabled", "68", "Disabled" };
			break;
		case "Advanced_USB_3":
			x = new string[5] { "Установите такой режим работы USB контроллера, при котором максимальная скорость передачи данных через USB порт составляет 12 Мбит/с.", "67", "Enabled", "69", "FullSpeed" };
			break;
		case "Advanced_Onb_0":
			y = new string[3] { "Отключите встроенный в материнскую плату аудио-контроллер.", "84", "Disabled" };
			break;
		case "Advanced_Onb_1":
			y = new string[3] { "Отключите встроенный в материнскую плату контроллер FireWire.", "86", "Disabled" };
			break;
		case "Advanced_Onb_2":
			y = new string[3] { "Отключите встроенную сетевую карту.", "87", "Disabled" };
			break;
		case "Advanced_Onb_3":
			y = new string[5] { "Разрешите производить удаленную загрузку операционной системы через сеть с удаленного сервера.", "87", "Enabled", "88", "Enabled" };
			break;
		case "Advanced_Onb_4":
			y = new string[3] { "Отключите возможность использования COM порта.", "91", "Disabled" };
			break;
		case "Advanced_Onb_5":
			y = new string[3] { "Отключите последовательный порт, выполненный по стандарту RS-232C.", "91", "Disabled" };
			break;
		case "Power_0":
			z = new string[11]
			{
				"Настройте автоматическое включение компьютера каждый день в 15:30:30 (HH:MM:SS).", "98", "Enabled", "99", "Every Day", "100", "15", "101", "30", "102",
				"30"
			};
			break;
		case "Power_1":
			z = new string[11]
			{
				"Настройте автоматическое включение компьютера каждый день в 21:00:00 (HH:MM:SS).", "98", "Enabled", "99", "Every Day", "100", "21", "101", "00", "102",
				"00"
			};
			break;
		case "Power_2":
			z = new string[11]
			{
				"Настройте автоматическое включение компьютера 10-го числа каждого месяца в 10:30:30 (HH:MM:SS).", "98", "Enabled", "99", "10", "100", "10", "101", "30", "102",
				"30"
			};
			break;
		case "Power_3":
			z = new string[11]
			{
				"Настройте автоматическое включение компьютера 20-го числа каждого месяца в 12:00:00 (HH:MM:SS).", "98", "Enabled", "99", "20", "100", "12", "101", "00", "102",
				"00"
			};
			break;
		case "Power_4":
			z = new string[3] { "Настройте компьютер таким образом, чтобы после внезапного исчезновения сетевого напряжения компьютер автоматически включался после подачи питания.", "97", "Power On" };
			break;
		case "Power_Other_0":
			aa = new string[3] { "Активируйте возможность включения компьютера от PS/2 клавиатуры при нажатии клавиши \"пробел\".", "106", "Space Bar" };
			break;
		case "Power_Other_1":
			aa = new string[3] { "Активируйте возможность включения компьютера от PS/2 клавиатуры при нажатии комбинации клавиш Ctrl-Esc.", "106", "Ctrl-Esc" };
			break;
		case "Power_Other_2":
			aa = new string[3] { "Активируйте возможность удаленного включения компьютера, находящегося в режиме soft-off (программное отключение) определенным сигналом поступающим на модем.", "103", "Enabled" };
			break;
		case "Power_Other_3":
			aa = new string[5] { "Настройте функцию автоматического регулирования скорости вращения процессорного вентилятора (ASUS Q-Fan) таким образом, чтобы вентилятор работал в самом тихом по уровню шума режиме.", "110", "Enabled", "111", "Silent Mode" };
			break;
		case "Boot_0":
			ab = new string[3] { "Установите пароль администратора (Supervisor password), соответствующий комбинации из 3 цифр: 123.", "135", "123" };
			break;
		case "Boot_1":
			ab = new string[3] { "Установите пароль администратора (Supervisor password), соответствующий комбинации из 5 цифр: 12345.", "135", "12345" };
			break;
		case "Boot_2":
			ab = new string[3] { "Установите пароль пользователя, соответствующий комбинации из 3 цифр: 123.", "136", "123" };
			break;
		case "Boot_3":
			ab = new string[3] { "Установите пароль пользователя, соответствующий комбинации из 5 цифр: 12345.", "136", "12345" };
			break;
		case "Boot_4":
			ab = new string[3] { "Задайте первым загрузочным устройством жесткий диск HDD:PM-Hitachi HDT.", "122", "HDD:PM-Hitachi HDT" };
			break;
		case "Boot_5":
			ab = new string[3] { "Задайте первым загрузочным устройством жесткий диск HDD:3M-ST3250824AS.", "122", "HDD:3M-ST3250824AS" };
			break;
		}
	}

	public void b()
	{
		k.ne();
		mm = new string[142]
		{
			k.x,
			k.y,
			k.z,
			k.ae,
			k.af,
			k.ag,
			k.ai,
			k.al,
			k.a3,
			k.a5,
			k.a7,
			k.a9,
			k.bb,
			k.bd,
			k.bf,
			k.br,
			k.bt,
			k.bv,
			k.bx,
			k.bz,
			k.b1,
			k.b3,
			k.cf,
			k.ch,
			k.cj,
			k.cl,
			k.cn,
			k.cp,
			k.cr,
			k.dp,
			k.ds,
			k.dv,
			k.dy,
			k.d7,
			k.ea,
			k.ed,
			k.eg,
			k.ej,
			k.em,
			k.eo,
			k.er,
			k.eu,
			k.ex,
			k.e0,
			k.e2,
			k.e5,
			k.e8,
			k.fb,
			k.fe,
			k.fh,
			k.fk,
			k.fn,
			k.fq,
			k.ft,
			k.fw,
			k.fz,
			k.f3,
			k.f6,
			k.f9,
			k.gc,
			k.gf,
			k.gi,
			k.gl,
			k.go,
			k.gr,
			k.gu,
			k.gx,
			k.g2,
			k.g5,
			k.g8,
			k.hb,
			k.he,
			k.hh,
			k.hn,
			k.ho,
			k.hu,
			k.hx,
			k.h0,
			k.h3,
			k.h6,
			k.ib,
			k.ie,
			k.ih,
			k.ik,
			k.io,
			k.ir,
			k.iu,
			k.ix,
			k.i0,
			k.i3,
			k.i6,
			k.i9,
			k.jd,
			k.jg,
			k.jj,
			k.jm,
			k.jp,
			k.jt,
			k.jw,
			k.jz,
			k.j1,
			k.j2,
			k.j3,
			k.j4,
			k.j7,
			k.ka,
			k.kd,
			k.kh,
			k.kk,
			k.kn,
			k.kq,
			k.kt,
			k.kw,
			k.kz,
			k.k2,
			k.k5,
			k.k8,
			k.lb,
			k.le,
			k.lh,
			k.lk,
			k.ln,
			k.lr,
			k.ls,
			k.lt,
			k.lu,
			k.ly,
			k.lz,
			k.l3,
			k.l6,
			k.l9,
			k.mc,
			k.mf,
			k.mi,
			k.ml,
			k.mo,
			k.mp,
			k.mr,
			k.mv,
			k.m7.ToString(CultureInfo.InvariantCulture),
			k.m8.ToString(CultureInfo.InvariantCulture),
			k.m9.ToString(CultureInfo.InvariantCulture)
		};
		a(ref s, 0);
		a(ref t, 1);
		a(ref u, 2);
		a(ref v, 3);
		a(ref w, 4);
		a(ref x, 5);
		a(ref y, 6);
		a(ref z, 7);
		a(ref aa, 8);
		a(ref ab, 9);
		l = new l(this);
		l.ShowDialog();
	}

	private void a(ref string[] A_0, int A_1)
	{
		int num = 0;
		for (int num2 = 1; num2 < A_0.Length; num2 += 2)
		{
			if (mm[int.Parse(A_0[num2], CultureInfo.InvariantCulture)] == A_0[num2 + 1])
			{
				num++;
			}
		}
		if (num == (A_0.Length - 1) / 2)
		{
			o[A_1] += q;
			r[A_1] = true;
		}
	}
}
