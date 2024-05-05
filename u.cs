using System;
using System.Drawing;
using System.Globalization;

public class u
{
	public ak a;

	public d b;

	public x c;

	public k d;

	public z e;

	public ad f;

	public Color g;

	public bool h;

	public m i;

	public string[] j;

	private s m_k;

	private h m_l;

	public string m;

	public string n = "←→    Select Screen\n↑↓        Select Item\nEnter  Update\nF1       General Help\nF10     Save and Exit\nESC    Exit";

	public string o = "←→   Select Screen\n↑↓       Select Item\n+ -      Change Option\nF1      General Help\nF10    Save and Exit\nESC   Exit";

	public string p = "←→    Select Screen\n↑↓        Select Item\nEnter  Go to Sub Screen\nF1       General Help\nF10     Save and Exit\nESC    Exit";

	public string q = "←→   Select Screen\n↑↓       Select Item\nF1      General Help\nF10    Save and Exit\nESC   Exit";

	public string r = "←→   Select Screen\n↑↓       Select Item\n+ -      Change Field\nTab    Select Field\nF1      General Help\nF10    Save and Exit\nESC   Exit";

	public string s = "←→   Select Screen\n↑↓       Select Item\nEnter Change\nF1      General Help\nF10    Save and Exit\nESC   Exit";

	private DateTime m_t;

	public string[] um = new string[24]
	{
		"00", "01", "02", "03", "04", "05", "06", "07", "08", "09",
		"10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
		"20", "21", "22", "23"
	};

	public string[] v = new string[60]
	{
		"00", "01", "02", "03", "04", "05", "06", "07", "08", "09",
		"10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
		"20", "21", "22", "23", "24", "25", "26", "27", "28", "29",
		"30", "31", "32", "33", "34", "35", "36", "37", "38", "39",
		"40", "41", "42", "43", "44", "45", "46", "47", "48", "49",
		"50", "51", "52", "53", "54", "55", "56", "57", "58", "59"
	};

	public string[] w = new string[60]
	{
		"00", "01", "02", "03", "04", "05", "06", "07", "08", "09",
		"10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
		"20", "21", "22", "23", "24", "25", "26", "27", "28", "29",
		"30", "31", "32", "33", "34", "35", "36", "37", "38", "39",
		"40", "41", "42", "43", "44", "45", "46", "47", "48", "49",
		"50", "51", "52", "53", "54", "55", "56", "57", "58", "59"
	};

	public string x = "12";

	public string y = "00";

	public string z = "00";

	public string aa = "Use [ENTER], [TAB] or [SHIFT-TAB] to select a field.\n\nUse [+] or [-] to configure system Time.";

	public string[] ab = new string[12]
	{
		"01", "02", "03", "04", "05", "06", "07", "08", "09", "10",
		"11", "12"
	};

	public string[] ac = new string[31]
	{
		"01", "02", "03", "04", "05", "06", "07", "08", "09", "10",
		"11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
		"21", "22", "23", "24", "25", "26", "27", "28", "29", "30",
		"31"
	};

	public string[] ad = new string[30]
	{
		"2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010",
		"2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020",
		"2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"
	};

	public string ae = "01";

	public string af = "01";

	public string ag = "2009";

	public string ah = "Use [ENTER], [TAB] or [SHIFT-TAB] to select a field.\n\nUse [+] or [-] to configure system Date.";

	public string ai = "1.44M, 3.5 in.";

	public string[] aj = new string[3] { "Disabled", "720K, 3.5 in.", "1.44M, 3.5 in." };

	public string ak = "<Enter> to select floppy type.";

	public string al = "English";

	public string[] am = new string[1] { "English" };

	public string an = "<Enter> to select display language for BIOS setup screen.";

	public string ao = "Hitachi HDT725032V";

	public string ap = "Not Detected";

	public string aq = "ST3250824AS";

	public string ar = "Not Detected";

	public string @as = "While entering setup, BIOS auto detects the presence of IDE devices. This displays the status of auto detection of IDE devices.";

	public bool at = true;

	public string au = "Hard Disk";

	public string av = "Hitachi HDT725032VLA360";

	public string aw = "320.0GB";

	public string ax = "Supported";

	public string ay = "16Sectors";

	public string az = "4";

	public string a0 = "MultiWord DMA-2";

	public string a1 = "Ultra DMA-5";

	public string a2 = "Supported";

	public string a3 = "Auto";

	public string[] a4 = new string[4] { "Not Installed", "Auto", "CDROM", "ARMD" };

	public string a5 = "Auto";

	public string[] a6 = new string[2] { "Disabled", "Auto" };

	public string a7 = "Auto";

	public string[] a8 = new string[2] { "Disabled", "Auto" };

	public string a9 = "Auto";

	public string[] ba = new string[6] { "Auto", "0", "1", "2", "3", "4" };

	public string bb = "Auto";

	public string[] bc = new string[13]
	{
		"Auto", "SWDMA0", "SWDMA1", "SWDMA2", "MWDMA0", "MWDMA1", "MWDMA2", "UDMA0", "UDMA1", "UDMA2",
		"UDMA3", "UDMA4", "UDMA5"
	};

	public string bd = "Auto";

	public string[] be = new string[3] { "Auto", "Disabled", "Enabled" };

	public string bf = "Enabled";

	public string[] bg = new string[2] { "Disabled", "Enabled" };

	public bool bh;

	public string bi = "Not Detected";

	public string bj = "";

	public string bk = "";

	public string bl = "";

	public string bm = "";

	public string bn = "";

	public string bo = "";

	public string bp = "";

	public string bq = "";

	public string br = "Auto";

	public string[] bs = new string[4] { "Not Installed", "Auto", "CDROM", "ARMD" };

	public string bt = "Auto";

	public string[] bu = new string[2] { "Disabled", "Auto" };

	public string bv = "Auto";

	public string[] bw = new string[2] { "Disabled", "Auto" };

	public string bx = "Auto";

	public string[] by = new string[6] { "Auto", "0", "1", "2", "3", "4" };

	public string bz = "Auto";

	public string[] b0 = new string[13]
	{
		"Auto", "SWDMA0", "SWDMA1", "SWDMA2", "MWDMA0", "MWDMA1", "MWDMA2", "UDMA0", "UDMA1", "UDMA2",
		"UDMA3", "UDMA4", "UDMA5"
	};

	public string b1 = "Auto";

	public string[] b2 = new string[3] { "Auto", "Disabled", "Enabled" };

	public string b3 = "Enabled";

	public string[] b4 = new string[2] { "Disabled", "Enabled" };

	public bool b5 = true;

	public string b6 = "Hard Disk";

	public string b7 = "ST3250824AS";

	public string b8 = "250.0GB";

	public string b9 = "Supported";

	public string ca = "16Sectors";

	public string cb = "4";

	public string cc = "MultiWord DMA-2";

	public string cd = "Ultra DMA-5";

	public string ce = "Supported";

	public string cf = "Auto";

	public string[] cg = new string[4] { "Not Installed", "Auto", "CDROM", "ARMD" };

	public string ch = "Auto";

	public string[] ci = new string[2] { "Disabled", "Auto" };

	public string cj = "Auto";

	public string[] ck = new string[2] { "Disabled", "Auto" };

	public string cl = "Auto";

	public string[] cm = new string[6] { "Auto", "0", "1", "2", "3", "4" };

	public string cn = "Auto";

	public string[] co = new string[13]
	{
		"Auto", "SWDMA0", "SWDMA1", "SWDMA2", "MWDMA0", "MWDMA1", "MWDMA2", "UDMA0", "UDMA1", "UDMA2",
		"UDMA3", "UDMA4", "UDMA5"
	};

	public string cp = "Auto";

	public string[] cq = new string[3] { "Auto", "Disabled", "Enabled" };

	public string cr = "Enabled";

	public string[] cs = new string[2] { "Disabled", "Enabled" };

	public bool ct;

	public string cu = "Not Detected";

	public string cv = "";

	public string cw = "";

	public string cx = "";

	public string cy = "";

	public string cz = "";

	public string c0 = "";

	public string c1 = "";

	public string c2 = "";

	public string c3 = "Auto";

	public string[] c4 = new string[4] { "Not Installed", "Auto", "CDROM", "ARMD" };

	public string c5 = "Auto";

	public string[] c6 = new string[2] { "Disabled", "Auto" };

	public string c7 = "Auto";

	public string[] c8 = new string[2] { "Disabled", "Auto" };

	public string c9 = "Auto";

	public string[] da = new string[6] { "Auto", "0", "1", "2", "3", "4" };

	public string db = "Auto";

	public string[] dc = new string[13]
	{
		"Auto", "SWDMA0", "SWDMA1", "SWDMA2", "MWDMA0", "MWDMA1", "MWDMA2", "UDMA0", "UDMA1", "UDMA2",
		"UDMA3", "UDMA4", "UDMA5"
	};

	public string dd = "Auto";

	public string[] de = new string[3] { "Auto", "Disabled", "Enabled" };

	public string df = "Enabled";

	public string[] dg = new string[2] { "Disabled", "Enabled" };

	public string dh = "Select the type of device connected to the system.";

	public string di = "Disabled: Disables LBA Mode.\nAuto: Enables LBA Mode if the device supports it and the device is not already formatted with LBA Mode disabled.";

	public string dj = "Disabled: The Data transfer from and to the device occurs one sector at a time.\nAuto: The Data transfer from and to the device occurs multiple sectors at a time if the device supports it.";

	public string dk = "<Enter> to select data transfer mode.";

	public string dl = "Select DMA Mode.\nAuto: Auto detected\nSWDMAn: SingleWordDMAn\nMWDMAn: MultiWordDMAn\nUDMAn: UltraDMAn";

	public string dm = "S.M.A.R.T. stands for Self-Monitoring, Analysis and Reporting Technology.";

	public string dn = "Enable/Disable 32-bit Data Transfer.";

	public string @do = "Configure the SATA\ndevice(s).";

	public string dp = "Enhanced";

	public string[] dq = new string[3] { "Disabled", "Compatible", "Enhanced" };

	public string dr = "Disabled\nCompatible\nEnhanced";

	public string ds = "IDE";

	public string[] dt = new string[1] { "IDE" };

	public string du = "IDE";

	public string dv = "Disabled";

	public string[] dw = new string[2] { "Disabled", "Enabled" };

	public string dx = "Disable/Enable device write protection. This will be effective only if device is accessed through BIOS.";

	public string dy = "35";

	public string[] dz = new string[8] { "0", "5", "10", "15", "20", "25", "30", "35" };

	public string d0 = "Select the time out value for detecting ATA/ATAPI device(s).";

	public string d1 = "1201";

	public string d2 = "10/14/08";

	public string d3 = "Intel(R) Core(TM)2 Duo CPU E7200 @\n  2.53GHz";

	public string d4 = "2533MHz";

	public string d5 = "2";

	public string d6 = "2048MB";

	public string d7 = "Auto";

	public string[] d8 = new string[3] { "Manual", "Auto", "N.O.S." };

	public string d9 = "[N.O.S.]\nWhen N.O.S. is enabled FSB frequency will be optimized automaticall depending on CPU loading.";

	public string ea = "Auto";

	public string[] eb = new string[4] { "Auto", "Standard", "Sensitive", "Heavy Load" };

	public string ec = "Different level to trigger NOS function";

	public string ed = "Overclock 3%";

	public string[] ee = new string[6] { "Overclock 3%", "Overclock 5%", "Overclock 10%", "Overclock 15%", "Overclock 20%", "Overclock 30%" };

	public string ef = "Different level of overclocking FSB frequency";

	public string eg = "Auto";

	public string[] eh = new string[9] { "Auto", "06.0", "06.5", "07.0", "07.5", "08.0", "08.5", "09.0", "09.5" };

	public string ei = "Sets the ratio between CPU Core Clock and the FSB Frequency.\nNOTE: If an invalid ratio is set in CMOS then actual and setpoint values may differ.\nNOTE: Please Key in ratio numbers directly!";

	public string ej = "Auto";

	public string[] ek = new string[5] { "Auto", "200MHz", "266MHz", "333MHz", "400MHz" };

	public string el = "Auto :\nFSB Strap will be adjusted automatically by FSB Frequency and DRAM Frequency.";

	public string em = "266";

	public string en = "Valid input value:\n200 - 800";

	public string eo = "Auto";

	public string[] ep = new string[53]
	{
		"Auto", "100", "101", "102", "103", "104", "105", "106", "107", "108",
		"109", "110", "111", "112", "113", "114", "115", "116", "117", "118",
		"119", "120", "121", "122", "123", "124", "125", "126", "127", "128",
		"129", "130", "131", "131", "132", "133", "134", "135", "136", "137",
		"138", "139", "140", "141", "142", "143", "144", "145", "146", "147",
		"148", "149", "150"
	};

	public string eq = "Valid input value:\n100 - 150";

	public string er = "Auto";

	public string[] es = new string[9] { "Auto", "DDR2-533MHz", "DDR2-639MHz", "DDR2-667MHz", "DDR2-709MHz", "DDR2-800MHz", "DDR2-852MHz", "DDR2-887MHz", "DDR2-1066MHz" };

	public string et = "DDR2 DRAM frequency lower than 667MHz may cause system boot failure due to spec. violation.";

	public string eu = "Auto";

	public string[] ev = new string[3] { "Auto", "1N", "2N" };

	public string ew = "1N :\nIt might accelerate DRAM perfomance.\n2N :\nIt might enhance DRAM overclocking ability.";

	public string ex = "Auto";

	public string[] ey = new string[2] { "Auto", "Manual" };

	public string ez = "Auto :\nAll dram timings are determined by SPD.";

	public string e0 = "5-5-5-15-4-42-6-3-3";

	public int[] e1 = new int[9] { 5, 5, 5, 15, 4, 42, 6, 3, 3 };

	public string e2 = "5 DRAM Clocks";

	public string[] e3 = new string[5] { "3 DRAM Clocks", "4 DRAM Clocks", "5 DRAM Clocks", "6 DRAM Clocks", "7 DRAM Clocks" };

	public string e4 = "[tCL]\nCAS# Latency";

	public string e5 = "5 DRAM Clocks";

	public string[] e6 = new string[8] { "3 DRAM Clocks", "4 DRAM Clocks", "5 DRAM Clocks", "6 DRAM Clocks", "7 DRAM Clocks", "8 DRAM Clocks", "9 DRAM Clocks", "10 DRAM Clocks" };

	public string e7 = "[tRCD]\nRAS# to CAS# Delay";

	public string e8 = "5 DRAM Clocks";

	public string[] e9 = new string[8] { "3 DRAM Clocks", "4 DRAM Clocks", "5 DRAM Clocks", "6 DRAM Clocks", "7 DRAM Clocks", "8 DRAM Clocks", "9 DRAM Clocks", "10 DRAM Clocks" };

	public string fa = "[tRP]\nRAS# Precharge Time";

	public string fb = "15 DRAM Clocks";

	public string[] fc = new string[32]
	{
		"3 DRAM Clocks", "4 DRAM Clocks", "5 DRAM Clocks", "6 DRAM Clocks", "7 DRAM Clocks", "8 DRAM Clocks", "9 DRAM Clocks", "10 DRAM Clocks", "11 DRAM Clocks", "12 DRAM Clocks",
		"13 DRAM Clocks", "14 DRAM Clocks", "15 DRAM Clocks", "16 DRAM Clocks", "17 DRAM Clocks", "18 DRAM Clocks", "19 DRAM Clocks", "20 DRAM Clocks", "21 DRAM Clocks", "22 DRAM Clocks",
		"23 DRAM Clocks", "24 DRAM Clocks", "25 DRAM Clocks", "26 DRAM Clocks", "27 DRAM Clocks", "28 DRAM Clocks", "29 DRAM Clocks", "30 DRAM Clocks", "31 DRAM Clocks", "32 DRAM Clocks",
		"33 DRAM Clocks", "34 DRAM Clocks"
	};

	public string fd = "[tRAS]\nRAS# Activate to Precharge Time";

	public string fe = "Auto";

	public string[] ff = new string[16]
	{
		"Auto", "1 DRAM Clocks", "2 DRAM Clocks", "3 DRAM Clocks", "4 DRAM Clocks", "5 DRAM Clocks", "6 DRAM Clocks", "7 DRAM Clocks", "8 DRAM Clocks", "9 DRAM Clocks",
		"10 DRAM Clocks", "11 DRAM Clocks", "12 DRAM Clocks", "13 DRAM Clocks", "14 DRAM Clocks", "15 DRAM Clocks"
	};

	public string fg = "[tRRD]\nRAS# to RAS# Delay";

	public string fh = "Auto";

	public string[] fi = new string[16]
	{
		"Auto", "20 DRAM Clocks", "25 DRAM Clocks", "30 DRAM Clocks", "35 DRAM Clocks", "40 DRAM Clocks", "45 DRAM Clocks", "50 DRAM Clocks", "55 DRAM Clocks", "60 DRAM Clocks",
		"65 DRAM Clocks", "70 DRAM Clocks", "80 DRAM Clocks", "85 DRAM Clocks", "105 DRAM Clocks", "132 DRAM Clocks"
	};

	public string fj = "[tRFC]\nRefresh Cycle Time";

	public string fk = "Auto";

	public string[] fl = new string[16]
	{
		"Auto", "1 DRAM Clocks", "2 DRAM Clocks", "3 DRAM Clocks", "4 DRAM Clocks", "5 DRAM Clocks", "6 DRAM Clocks", "7 DRAM Clocks", "8 DRAM Clocks", "9 DRAM Clocks",
		"10 DRAM Clocks", "11 DRAM Clocks", "12 DRAM Clocks", "13 DRAM Clocks", "14 DRAM Clocks", "15 DRAM Clocks"
	};

	public string fm = "[tWR]\nWrite Recovery Time";

	public string fn = "Auto";

	public string[] fo = new string[16]
	{
		"Auto", "1 DRAM Clocks", "2 DRAM Clocks", "3 DRAM Clocks", "4 DRAM Clocks", "5 DRAM Clocks", "6 DRAM Clocks", "7 DRAM Clocks", "8 DRAM Clocks", "9 DRAM Clocks",
		"10 DRAM Clocks", "11 DRAM Clocks", "12 DRAM Clocks", "13 DRAM Clocks", "14 DRAM Clocks", "15 DRAM Clocks"
	};

	public string fp = "[tWTR]\nWrite to Read Delay";

	public string fq = "Auto";

	public string[] fr = new string[16]
	{
		"Auto", "1 DRAM Clocks", "2 DRAM Clocks", "3 DRAM Clocks", "4 DRAM Clocks", "5 DRAM Clocks", "6 DRAM Clocks", "7 DRAM Clocks", "8 DRAM Clocks", "9 DRAM Clocks",
		"10 DRAM Clocks", "11 DRAM Clocks", "12 DRAM Clocks", "13 DRAM Clocks", "14 DRAM Clocks", "15 DRAM Clocks"
	};

	public string fs = "[tRTP]\nRead to Precharge Time";

	public string ft = "Auto";

	public string[] fu = new string[3] { "Auto", "Disabled", "Enabled" };

	public string fv = "Disabled :\nIt might enhance DRAM overclocking ability.";

	public string fw = "Auto";

	public string[] fx = new string[3] { "Auto", "Disabled", "Enabled" };

	public string fy = "It will affect system perfomance and stability directly.";

	public string fz = "0";

	public string[] f0 = new string[4] { "0", "1", "2", "3" };

	public string f1 = "Set higher level to get better perfomance\nRange : 0 - 3";

	public string f2 = "Set higher level to get better compatibility\nRange : 0 - 3";

	public string f3 = "Auto";

	public string[] f4 = new string[50]
	{
		"Auto", "1.7000V", "1.6875V", "1.6750V", "1.6625V", "1.6500V", "1.6375V", "1.6250V", "1.6125V", "1.6000V",
		"1.5875V", "1.5750V", "1.5625V", "1.5500V", "1.5375V", "1.5250V", "1.5125V", "1.5000V", "1.4875V", "1.4750V",
		"1.4625V", "1.4500V", "1.4375V", "1.4250V", "1.4125V", "1.4000V", "1.3875V", "1.3750V", "1.3625V", "1.3500V",
		"1.3375V", "1.3250V", "1.3125V", "1.3000V", "1.2875V", "1.2750V", "1.2625V", "1.2500V", "1.2375V", "1.2250V",
		"1.2125V", "1.2000V", "1.1875V", "1.1750V", "1.1625V", "1.1500V", "1.1375V", "1.1250V", "1.1125V", "1.1000V"
	};

	public string f5 = "Min = 1.1000V\nMax = 1.7000V\nStandard = By CPU\nIncrement = 0.0125V";

	public string f6 = "Auto";

	public string[] f7 = new string[3] { "Auto", "1.50V", "1.70V" };

	public string f8 = "Min = 1.50V\nMax = 1.80V\nStandard = 1.50V\nIncrement = 0.10V";

	public string f9 = "Auto";

	public string[] ga = new string[5] { "Auto", "1.10V", "1.20V", "1.30V", "1.40V" };

	public string gb = "Min = 1.20V(*)\nMax = 1.50V(*)\nStandard = 1.20V(*)\nIncrement = 0.10V\n\n* : Standard, Min and Max become 1.10V, 1.10V and 1.40V, when 45nm CPU is detected.";

	public string gc = "Auto";

	public string[] gd = new string[17]
	{
		"Auto", "1.80V", "1.85V", "1.90V", "1.95V", "2.00V", "2.05V", "2.10V", "2.15V", "2.20V",
		"2.25V", "2.30V", "2.35V", "2.40V", "2.45V", "2.50V", "2.55V"
	};

	public string ge = "Min = 1.50V\nMax = 2.25V\nStandard = 1.50V\nIncrement = 0.05V";

	public string gf = "Auto";

	public string[] gg = new string[5] { "Auto", "1.25V", "1.40V", "1.55V", "1.70V" };

	public string gh = "Min = 1.25V\nMax = 1.70V\nStandard = 1.25V\nIncrement = 0.15V";

	public string gi = "Auto";

	public string[] gj = new string[5] { "Auto", "0.70V", "0.80V", "0.90V", "1.00V" };

	public string gk = "Min = 0.70V\nMax = 1.00V\nStandard = 0.80V\nIncrement = 0.10V";

	public string gl = "Auto";

	public string[] gm = new string[3] { "Auto", "Disabled", "Enabled" };

	public string gn = "Disabled :\nFollow Intel Spec.\nEnabled :\nImprove VDroop directly";

	public string go = "Auto";

	public string[] gp = new string[5] { "Auto", "0.63x", "0.61x", "0.59x", "0.57x" };

	public string gq = "Different ratio might enhance CPU overclocking ability.";

	public string gr = "Auto";

	public string[] gs = new string[3] { "Auto", "0.67x", "0.61x" };

	public string gt = "Different ratio might enhance CPU overclocking ability.";

	public string gu = "Auto";

	public string[] gv = new string[2] { "Auto", "Disabled" };

	public string gw = "Disabled :\nIt might enhance FSB overclocking ability.";

	public string gx = "Auto";

	public string[] gy = new string[2] { "Auto", "Disabled" };

	public string gz = "Disabled :\nIt might enhance PCIE overclocking ability.";

	public string g0 = "Configure the USB support.";

	public string g1 = "1 Mouse";

	public string g2 = "Enabled";

	public string[] g3 = new string[2] { "Disabled", "Enabled" };

	public string g4 = "Disabled\nEnabled";

	public string g5 = "Enabled";

	public string[] g6 = new string[2] { "Enabled", "Disabled" };

	public string g7 = "Enabled\nDisabled";

	public string g8 = "HiSpeed";

	public string[] g9 = new string[2] { "FullSpeed", "HiSpeed" };

	public string ha = "Configures the USB 2.0 controller in HiSpeed (480Mbps) or FullSpeed (12Mbps).";

	public string hb = "Enabled";

	public string[] hc = new string[2] { "Disabled", "Enabled" };

	public string hd = "This is a workaround for OSes without EHCI hand-off support.\nThe EHCI ownership change should claim by EHCI driver.";

	public string he = "Disabled";

	public string[] hf = new string[2] { "Disabled", "Enabled" };

	public string hg = "Enables I/O port 60h/64h emulation support. This should be enabled for the complete USB keyboard legacy support for non-USB aware OSes.";

	public string hh = "Auto";

	public string[] hi = new string[3] { "Disabled", "Enabled", "Auto" };

	public string hj = "Enables support for legacy USB. AUTO option disables legacy support if no USB devices are connected.";

	public string hk = "Configure CPU.";

	public string hl = "Intel";

	public string hm = "Intel(R) Core(TM)2 Duo CPU E7200 @\n 2.53GHz";

	public string hn = "2.53GHz";

	public string ho = "1066MHz";

	public string hp = "64 KB";

	public string hq = "3072 KB";

	public string hr = "10676";

	public string hs = "Unlocked (Max:09.5, Min:06.0)";

	public string ht = "9.5";

	public string hu = "Enabled";

	public string[] hv = new string[2] { "Disabled", "Enabled" };

	public string hw = "This should be enabled in order to enable or disable the \"Enhanced Halt State\".";

	public string hx = "Enabled";

	public string[] hy = new string[2] { "Disabled", "Enabled" };

	public string hz = "For the processor its CPUID belows 0F41h.\nTM2 only can be enable under below setting.\n1.Freq.>=3.6GHz FSB800\n2.Freq.>=2.8GHz FSB533";

	public string h0 = "Enabled";

	public string[] h1 = new string[2] { "Disabled", "Enabled" };

	public string h2 = "When disabled, force the XD feature flag to always return 0.";

	public string h3 = "Disabled";

	public string[] h4 = new string[2] { "Disabled", "Enabled" };

	public string h5 = "Disabled for WindowsXP";

	public string h6 = "Enabled";

	public string[] h7 = new string[2] { "Enabled", "Disabled" };

	public string h8 = "Automatic: CPU speed controlled by Operating system.\nDisabled: Default CPU speed.";

	public string h9 = "Set Chipset, DRAM, and Clock related parameters.";

	public string ia = "Configure North Bridge features.";

	public string ib = "Enabled";

	public string[] ic = new string[2] { "Disabled", "Enabled" };

	public string id = "ENABLE: Allow remapping of overlapped PCI memory above the total physical memory.\n\nDISABLE: Do not allow remapping of memory.";

	public string ie = "PEG/PCI";

	public string[] @if = new string[2] { "PCI/PEG", "PEG/PCI" };

	public string ig = "Select which graphics controller to use as the primary boot device.";

	public string ih = "Auto";

	public string[] ii = new string[2] { "Auto", "Disabled" };

	public string ij = "Auto\nDisabled";

	public string ik = "Disabled";

	public string[] il = new string[2] { "Enabled", "Disabled" };

	public string im = "Enabled\nDisabled";

	public string @in = "Set onboard devices related parameters.";

	public string io = "Enabled";

	public string[] ip = new string[2] { "Enabled", "Disabled" };

	public string iq = "Enable or Disable High Definition Audio Controller";

	public string ir = "HD Audio";

	public string[] @is = new string[2] { "AC97", "HD Audio" };

	public string it = "If High Definition Audio Front Panel used, pls set HD Audio Mode";

	public string iu = "Enabled";

	public string[] iv = new string[2] { "Enabled", "Disabled" };

	public string iw = "Enable or disable onboard IEEE 1394 controller.";

	public string ix = "Enabled";

	public string[] iy = new string[2] { "Enabled", "Disabled" };

	public string iz = "Onboard PCIEX Gbe LAN Enable/Disable";

	public string i0 = "Disabled";

	public string[] i1 = new string[2] { "Disabled", "Enabled" };

	public string i2 = "Onboard PCIEX Gbe LAN Boot ROM Configuration";

	public string i3 = "Enabled";

	public string[] i4 = new string[2] { "Enabled", "Disabled" };

	public string i5 = "Enabled\nDisabled";

	public string i6 = "IDE";

	public string[] i7 = new string[3] { "RAID", "IDE", "AHCI" };

	public string i8 = "RAID\nIDE\nAHCI";

	public string i9 = "3F8/IRQ4";

	public string[] ja = new string[5] { "Disabled", "3F8/IRQ4", "2F8/IRQ3", "3E8/IRQ4", "2E8/IRQ3" };

	public string jb = "Allows BIOS to Select Serial Port1 Base Addresses.";

	public string jc = "Configure PCI and PNP related parameters.";

	public string jd = "NO";

	public string[] je = new string[2] { "NO", "YES" };

	public string jf = "NO: lets the BIOS configure all the devices in the system.\nYES: lets the operating system configure Plug and Play (PnP) devices not required for boot if your system has a Plug and Play operating system.";

	public string jg = "Auto";

	public string[] jh = new string[3] { "S1 (POS) only", "S3 only", "Auto" };

	public string ji = "Select the ACPI state used for System Suspend.";

	public string jj = "Disabled";

	public string[] jk = new string[2] { "Disabled", "Enabled" };

	public string jl = "Determines whether to invoke VGA BIOS post on S3/STR resume if some of VGA can't resume.";

	public string jm = "Disabled";

	public string[] jn = new string[2] { "Disabled", "Enabled" };

	public string jo = "Add additional tables as per ACPI 2.0 specifications.";

	public string jp = "Enabled";

	public string[] jq = new string[2] { "Disabled", "Enabled" };

	public string jr = "Include ACPI APIC table pointer to RSDT pointer list.";

	public string js = "APM Functions";

	public string jt = "Power Off";

	public string[] ju = new string[3] { "Power Off", "Power On", "Last State" };

	public string jv = "<Enter> to select whether or not to restart the system after AC power loss.";

	public string jw = "Disabled";

	public string[] jx = new string[2] { "Disabled", "Enabled" };

	public string jy = "Disable/Enable\nRTC to generate a wake event.";

	public string jz = "15";

	public string[] j0 = new string[32]
	{
		"01", "02", "03", "04", "05", "06", "07", "08", "09", "10",
		"11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
		"21", "22", "23", "24", "25", "26", "27", "28", "29", "30",
		"31", "Every Day"
	};

	public string j1 = "12";

	public string j2 = "30";

	public string j3 = "30";

	public string j4 = "Disabled";

	public string[] j5 = new string[2] { "Disabled", "Enabled" };

	public string j6 = "Disable/Enable\nRI to generate a wake event.";

	public string j7 = "Disabled";

	public string[] j8 = new string[2] { "Disabled", "Enabled" };

	public string j9 = "Disable/Enable\nPME to generate a wake event.";

	public string ka = "Disabled";

	public string[] kb = new string[2] { "Disabled", "Enabled" };

	public string kc = "Disable/Enable\nPCIE to generate a wake event.";

	public string kd = "Disabled";

	public string[] ke = new string[4] { "Disabled", "Space Bar", "Ctrl-Esc", "Power Key" };

	public string kf = "Power on system by keystroke of PS/2 keyboards.";

	public string kg = "Hardware Monitor Functions (It will cost some time to detect Fan speed)";

	public string kh = "37ºC/98.5ºF";

	public string[] ki = new string[2] { "Ignored", "37ºC/98.5ºF" };

	public string kj = "CPU Temperature";

	public string kk = "34ºC/93ºF";

	public string[] kl = new string[2] { "Ignored", "34ºC/93ºF" };

	public string km = "MB Temperature";

	public string kn = "1278RPM";

	public string[] ko = new string[2] { "Ignored", "1278RPM" };

	public string kp = "CPU Fan Speed";

	public string kq = "Disabled";

	public string[] kr = new string[2] { "Disabled", "Enabled" };

	public string ks = "CPU Q-Fan Control";

	public string kt = "Optimal";

	public string[] ku = new string[3] { "Optimal", "Silent Mode", "Perfomance Mode" };

	public string kv = "Optimal Mode:\nEnable middle quiet\n\nSilent Mode:\nEnable super quiet\n\nPerfomance Mode:\nEnable slight quiet operation for heavy-loading computing.";

	public string kw = "N/A";

	public string[] kx = new string[2] { "Ignored", "N/A" };

	public string ky = "Chassis Fan 1 Speed";

	public string kz = "1383RPM";

	public string[] k0 = new string[2] { "Ignored", "1383RPM" };

	public string k1 = "Chassis Fan 2 Speed";

	public string k2 = "Disabled";

	public string[] k3 = new string[2] { "Disabled", "Enabled" };

	public string k4 = "Chassis Q-Fan Control";

	public string k5 = "Auto";

	public string[] k6 = new string[5] { "Auto", "90%", "80%", "70%", "60%" };

	public string k7 = "Select the fan speed ratio for fans to operate at low CPU temperature.\nSet a very low ratio may cause dramatical fan speed drop and trigger hardware monitor warning message.";

	public string k8 = "45ºC";

	public string[] k9 = new string[7] { "36ºC", "39ºC", "42ºC", "45ºC", "48ºC", "51ºC", "54ºC" };

	public string la = "CPU Fan speed will be adjusted to let CPU temperature as low as this temperature.";

	public string lb = "N/A";

	public string[] lc = new string[2] { "Ignored", "N/A" };

	public string ld = "Power Fan Speed";

	public string le = "  1.152V";

	public string[] lf = new string[2] { "Ignored", "  1.152V" };

	public string lg = "VCORE Voltage";

	public string lh = "  3.312V";

	public string[] li = new string[2] { "Ignored", "  3.312V" };

	public string lj = "3.3V Voltage";

	public string lk = "  5.088V";

	public string[] ll = new string[2] { "Ignored", "  5.088V" };

	public string lm = "5V Voltage";

	public string ln = "12.040V";

	public string[] lo = new string[2] { "Ignored", "12.040V" };

	public string lp = "12V Voltage";

	public string lq = "Specifies the Boot Device Priority sequence.\n\nA virtual floppy disk drive (Floppy Drive B:) may appear when you set the CD-ROM drive as the first boot device.";

	public string lr = "1st FLOPPY DRIVE";

	public string ls = "HDD:PM-Hitachi HDT";

	public string lt = "ATAPI CD-ROM";

	public string lu = "IDE:DVDR PX-750A";

	public string[] lv = new string[5] { "1st FLOPPY DRIVE", "HDD:PM-Hitachi HDT", "ATAPI CD-ROM", "IDE:DVDR PX-750A", "Disabled" };

	public string lw = "Specifies the boot sequence from the available devices.\n\nA device enclosed in parenthesis has been disabled in the corresponding type menu.";

	public string lx = "Specifies the Boot Device Priority sequence from available Hard Drives.";

	public string ly = "HDD:PM-Hitachi HDT";

	public string lz = "HDD:3M-ST3250824AS";

	public string[] l0 = new string[3] { "HDD:PM-Hitachi HDT", "HDD:3M-ST3250824AS", "Disabled" };

	public string l1 = "Specifies the boot sequence from the available devices.";

	public string l2 = "Configure Settings\nduring System Boot.";

	public string l3 = "Enabled";

	public string[] l4 = new string[2] { "Disabled", "Enabled" };

	public string l5 = "Allows BIOS to skip certain tests while booting. This will decrease the time needed to boot the system.";

	public string l6 = "Enabled";

	public string[] l7 = new string[2] { "Disabled", "Enabled" };

	public string l8 = "Disabled: Displays normal POST messages.\nEnabled: Displays OEM Logo instead of POST messages.";

	public string l9 = "Force BIOS";

	public string[] ma = new string[2] { "Force BIOS", "Keep Current" };

	public string mb = "Set display mode for Option ROM.";

	public string mc = "On";

	public string[] md = new string[2] { "Off", "On" };

	public string me = "Select Power-on state for Numlock.";

	public string mf = "Enabled";

	public string[] mg = new string[2] { "Disabled", "Enabled" };

	public string mh = "Wait for F1 key to be pressed if error occurs.";

	public string mi = "Enabled";

	public string[] mj = new string[2] { "Disabled", "Enabled" };

	public string mk = "Displays \"Press DEL to run Setup\" in POST.";

	public string ml = "Disabled";

	public string[] mm = new string[2] { "Disabled", "Enabled" };

	public string mn = "Enabled: Allows option ROMs to trap interrupt 19. This is required by some PCI cards that provide a ROM based setup utility.";

	public string mo = "";

	public string mp = "";

	public string mq = "<Enter> to change password.\n<Enter> again to disable password.";

	public string mr = "Full Access";

	public string[] ms = new string[4] { "No Access", "View Only", "Limited", "Full Access" };

	public string mt = "LIMITED: only limited fields to be changed.\nNO ACCESS: prevent user access Setup Utility.\nVIEW ONLY: allow access but the fields can not be changed.\nFULL: allow change except Supervisor password.";

	public string mu = "Immediately clears the User password.";

	public string mv = "Setup";

	public string[] mw = new string[2] { "Setup", "Always" };

	public string mx = "Setup: Check password while invoking setup.\nAlways: Check password while invoking setup a well as on each boot.";

	public string my = "Press ENTER to run the utility to select and update BIOS.\nThis utility doesn't support:\n1.NTFS format";

	public string mz = "Save configuration changes and exit now?";

	public string m0 = "Exit system setup after saving the changes.\n\nF10 key can be used for this operation.";

	public string m1 = "Discard configuration changes and exit now?";

	public string m2 = "Exit system setup without saving any changes.\n\nESC key can be used for this operation.";

	public string m3 = "Discard Changes?";

	public string m4 = "Discards changes done so far to any of the setup questions.\n\nF7 key can be used for this operation.";

	public string m5 = "Load Setup Defaults?";

	public string m6 = "Load Setup Default values for all the setup questions.\n\nF5 key can be used for this operation.";

	public double m7;

	public double m8;

	public double m9;

	private void k()
	{
		j = new string[139]
		{
			x, y, z, ae, af, ag, ai, al, a3, a5,
			a7, a9, bb, bd, bf, br, bt, bv, bx, bz,
			b1, b3, cf, ch, cj, cl, cn, cp, cr, dp,
			ds, dv, dy, d7, ea, ed, eg, ej, em, eo,
			er, eu, ex, e0, e2, e5, e8, fb, fe, fh,
			fk, fn, fq, ft, fw, fz, f3, f6, f9, gc,
			gf, gi, gl, go, gr, gu, gx, g2, g5, g8,
			hb, he, hh, hn, ho, hu, hx, h0, h3, h6,
			ib, ie, ih, ik, io, ir, iu, ix, i0, i3,
			i6, i9, jd, jg, jj, jm, jp, jt, jw, jz,
			j1, j2, j3, j4, j7, ka, kd, kh, kk, kn,
			kq, kt, kw, kz, k2, k5, k8, lb, le, lh,
			lk, ln, lr, ls, lt, lu, ly, lz, l3, l6,
			l9, mc, mf, mi, ml, mo, mp, mr, mv
		};
	}

	public u(bool A_0, s A_1, h A_2)
	{
		h = A_0;
		this.m_k = A_1;
		this.m_l = A_2;
		g = Color.FromArgb(27, 35, 165);
		this.m_t = DateTime.Now;
		x = this.m_t.Hour.ToString("0#", CultureInfo.InvariantCulture);
		y = this.m_t.Minute.ToString("0#", CultureInfo.InvariantCulture);
		z = this.m_t.Second.ToString("0#", CultureInfo.InvariantCulture);
		ae = this.m_t.Month.ToString("0#", CultureInfo.InvariantCulture);
		af = this.m_t.Day.ToString("0#", CultureInfo.InvariantCulture);
		ag = this.m_t.Year.ToString(CultureInfo.InvariantCulture);
		k();
		a = new ak(this);
		b = new d(this);
		c = new x(this);
		d = new k(this);
		e = new z(this);
		f = new ad(this);
	}

	public string k(string A_0)
	{
		return "[" + A_0 + "]";
	}

	public void ne()
	{
		if (eg == "Auto")
		{
			m8 = 9.5;
		}
		else
		{
			m8 = double.Parse(eg, CultureInfo.InvariantCulture);
		}
		m7 = double.Parse(em, CultureInfo.InvariantCulture) * m8;
		m9 = double.Parse(em, CultureInfo.InvariantCulture) * 4.0 + 1.0;
	}

	public void k(ref string A_0, string[] A_1, bool A_2)
	{
		int num = A_1.Length - 1;
		int num2 = Array.IndexOf(A_1, A_0);
		num2 = (A_2 ? ((num2 != -1 && num2 < num) ? (num2 + 1) : 0) : ((num2 == -1 || num2 <= 0) ? num : (num2 - 1)));
		A_0 = A_1[num2];
	}

	public void t()
	{
		x = j[0];
		y = j[1];
		z = j[2];
		ae = j[3];
		af = j[4];
		ag = j[5];
		ai = j[6];
		al = j[7];
		a3 = j[8];
		a5 = j[9];
		a7 = j[10];
		a9 = j[11];
		bb = j[12];
		bd = j[13];
		bf = j[14];
		br = j[15];
		bt = j[16];
		bv = j[17];
		bx = j[18];
		bz = j[19];
		b1 = j[20];
		b3 = j[21];
		cf = j[22];
		ch = j[23];
		cj = j[24];
		cl = j[25];
		cn = j[26];
		cp = j[27];
		cr = j[28];
		dp = j[29];
		ds = j[30];
		dv = j[31];
		dy = j[32];
		d7 = j[33];
		ea = j[34];
		ed = j[35];
		eg = j[36];
		ej = j[37];
		em = j[38];
		eo = j[39];
		er = j[40];
		eu = j[41];
		ex = j[42];
		e0 = j[43];
		e2 = j[44];
		e5 = j[45];
		e8 = j[46];
		fb = j[47];
		fe = j[48];
		fh = j[49];
		fk = j[50];
		fn = j[51];
		fq = j[52];
		ft = j[53];
		fw = j[54];
		fz = j[55];
		f3 = j[56];
		f6 = j[57];
		f9 = j[58];
		gc = j[59];
		gf = j[60];
		gi = j[61];
		gl = j[62];
		go = j[63];
		gr = j[64];
		gu = j[65];
		gx = j[66];
		g2 = j[67];
		g5 = j[68];
		g8 = j[69];
		hb = j[70];
		he = j[71];
		hh = j[72];
		hn = j[73];
		ho = j[74];
		hu = j[75];
		hx = j[76];
		h0 = j[77];
		h3 = j[78];
		h6 = j[79];
		ib = j[80];
		ie = j[81];
		ih = j[82];
		ik = j[83];
		io = j[84];
		ir = j[85];
		iu = j[86];
		ix = j[87];
		i0 = j[88];
		i3 = j[89];
		i6 = j[90];
		i9 = j[91];
		jd = j[92];
		jg = j[93];
		jj = j[94];
		jm = j[95];
		jp = j[96];
		jt = j[97];
		jw = j[98];
		jz = j[99];
		j1 = j[100];
		j2 = j[101];
		j3 = j[102];
		j4 = j[103];
		j7 = j[104];
		ka = j[105];
		kd = j[106];
		kh = j[107];
		kk = j[108];
		kn = j[109];
		kq = j[110];
		kt = j[111];
		kw = j[112];
		kz = j[113];
		k2 = j[114];
		k5 = j[115];
		k8 = j[116];
		lb = j[117];
		le = j[118];
		lh = j[119];
		lk = j[120];
		ln = j[121];
		lr = j[122];
		ls = j[123];
		lt = j[124];
		lu = j[125];
		ly = j[126];
		lz = j[127];
		l3 = j[128];
		l6 = j[129];
		l9 = j[130];
		mc = j[131];
		mf = j[132];
		mi = j[133];
		ml = j[134];
		mo = j[135];
		mp = j[136];
		mr = j[137];
		mv = j[138];
		a.d();
		c.d();
	}

	public void ng()
	{
		i i2 = new i();
		i2.ShowDialog();
	}

	public void na()
	{
		a a2 = new a(this, m5);
		a2.ShowDialog();
	}

	public void nd()
	{
		a a2 = new a(this, m3);
		a2.ShowDialog();
	}

	public void l()
	{
		a a2 = new a(this, mz);
		a2.ShowDialog();
	}

	public void nf()
	{
		a a2 = new a(this, m1);
		a2.ShowDialog();
	}

	public void nb()
	{
		a.az = false;
		a.Close();
		b.ad = false;
		b.Close();
		c.af = false;
		c.Close();
		d.z = false;
		d.Close();
		e.t = false;
		e.Close();
		f.w = false;
		f.Close();
		if (h)
		{
			i.b();
			this.m_l.Close();
		}
		this.m_k.Show();
	}

	public void nc()
	{
		this.m_l.ShowDialog();
	}
}
