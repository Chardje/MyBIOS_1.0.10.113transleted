using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using MyBIOS.Properties;

public class s : Form
{
	private IContainer m_a;

	private Button m_b;

	private PictureBox m_c;

	private PictureBox m_d;

	private Button m_e;

	private Label m_f;

	private Label m_g;

	private Label h;

	private Panel i;

	private Label j;

	private PictureBox k;

	private u l;

	private h m;

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		base.Dispose(disposing);
	}

	private void b()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(s));
		this.m_b = new Button();
		this.m_e = new Button();
		this.m_f = new Label();
		this.m_g = new Label();
		h = new Label();
		i = new Panel();
		k = new PictureBox();
		j = new Label();
		this.m_d = new PictureBox();
		this.m_c = new PictureBox();
		i.SuspendLayout();
		((ISupportInitialize)k).BeginInit();
		((ISupportInitialize)this.m_d).BeginInit();
		((ISupportInitialize)this.m_c).BeginInit();
		SuspendLayout();
		this.m_b.Font = new Font("Verdana", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		this.m_b.ForeColor = Color.Black;
		this.m_b.Location = new Point(98, 122);
		this.m_b.Name = "StartDemo";
		this.m_b.Size = new Size(110, 32);
		this.m_b.TabIndex = 0;
		this.m_b.Text = "Демо";
		this.m_b.UseVisualStyleBackColor = true;
		this.m_b.Click += g;
		this.m_b.MouseEnter += e;
		this.m_b.MouseLeave += d;
		this.m_e.Font = new Font("Verdana", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		this.m_e.ForeColor = Color.Black;
		this.m_e.Location = new Point(98, 184);
		this.m_e.Name = "TestMode";
		this.m_e.Size = new Size(110, 32);
		this.m_e.TabIndex = 1;
		this.m_e.Text = "Тест";
		this.m_e.UseVisualStyleBackColor = true;
		this.m_e.Click += f;
		this.m_e.MouseEnter += c;
		this.m_e.MouseLeave += b;
		this.m_f.AutoSize = true;
		this.m_f.Font = new Font("Verdana", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		this.m_f.ForeColor = Color.White;
		this.m_f.Location = new Point(226, 125);
		this.m_f.Name = "StartDemo_label";
		this.m_f.Size = new Size(204, 23);
		this.m_f.TabIndex = 15;
		this.m_f.Text = "Запустити емулятор";
		this.m_g.AutoSize = true;
		this.m_g.Font = new Font("Verdana", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		this.m_g.ForeColor = Color.White;
		this.m_g.Location = new Point(226, 187);
		this.m_g.Name = "TestMode_label";
		this.m_g.Size = new Size(363, 23);
		this.m_g.TabIndex = 16;
		this.m_g.Text = "Запустити емулятор с 10 заданиями";
		h.AutoSize = true;
		h.Cursor = Cursors.Hand;
		h.ForeColor = Color.White;
		h.Location = new Point(600, 9);
		h.Name = "About";
		h.Size = new Size(117, 18);
		h.TabIndex = 17;
		h.Text = "Про программу";
		h.Click += a;
		i.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		i.BackColor = Color.DimGray;
		i.Controls.Add(k);
		i.Controls.Add(j);
		i.Font = new Font("Verdana", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		i.ForeColor = Color.White;
		i.Location = new Point(50, 296);
		i.Name = "MessagePanel";
		i.Size = new Size(632, 94);
		i.TabIndex = 19;
		i.Visible = false;
		k.Image = (Image)componentResourceManager.GetObject("Picture.Image");
		k.Location = new Point(0, 0);
		k.Name = "Picture";
		k.Size = new Size(40, 40);
		k.TabIndex = 20;
		k.TabStop = false;
		j.Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
		j.ForeColor = Color.White;
		j.Location = new Point(45, 0);
		j.Name = "MessageForUsers";
		j.Size = new Size(568, 74);
		j.TabIndex = 19;
		this.m_d.Image = Resources.Forward_d;
		this.m_d.Location = new Point(54, 184);
		this.m_d.Name = "TestMode_pict";
		this.m_d.Size = new Size(32, 32);
		this.m_d.TabIndex = 3;
		this.m_d.TabStop = false;
		this.m_c.Image = Resources.Forward_d;
		this.m_c.Location = new Point(54, 122);
		this.m_c.Name = "StartDemo_pict";
		this.m_c.Size = new Size(32, 32);
		this.m_c.TabIndex = 1;
		this.m_c.TabStop = false;
		base.AutoScaleDimensions = new SizeF(10f, 18f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.DimGray;
		base.ClientSize = new Size(740, 388);
		base.Controls.Add(i);
		base.Controls.Add(h);
		base.Controls.Add(this.m_g);
		base.Controls.Add(this.m_f);
		base.Controls.Add(this.m_e);
		base.Controls.Add(this.m_d);
		base.Controls.Add(this.m_c);
		base.Controls.Add(this.m_b);
		Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.MaximizeBox = false;
		base.Name = "Start_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "MyBIOS v1.0.10.113";
		i.ResumeLayout(performLayout: false);
		((ISupportInitialize)k).EndInit();
		((ISupportInitialize)this.m_d).EndInit();
		((ISupportInitialize)this.m_c).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public s()
	{
		b();
		a();
	}

	private void a()
	{
		int num = SystemInformation.PrimaryMonitorSize.Width;
		int num2 = SystemInformation.PrimaryMonitorSize.Height;
		if (num < 1200 || num2 < 800)
		{
			j.Text = "Разрешение Вашего экрана составляет " + num.ToString(CultureInfo.InvariantCulture) + "x" + num2.ToString(CultureInfo.InvariantCulture) + " точек и\nНЕ СООТВЕТСТВУЕТ рекомендуемому для работы программы.\nДля нормального отображения всех элементов эмулятора необходим экран с разрешением 1200х800 или выше.";
			i.Visible = true;
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		l = new u(A_0: false, this, m);
		l.a.Show();
		Hide();
	}

	private void f(object A_0, EventArgs A_1)
	{
		m = new h(this);
		m.Show();
		Hide();
	}

	private void e(object A_0, EventArgs A_1)
	{
		this.m_c.Image = Resources.Forward;
	}

	private void d(object A_0, EventArgs A_1)
	{
		this.m_c.Image = Resources.Forward_d;
	}

	private void c(object A_0, EventArgs A_1)
	{
		this.m_d.Image = Resources.Forward;
	}

	private void b(object A_0, EventArgs A_1)
	{
		this.m_d.Image = Resources.Forward_d;
	}

	private void a(object A_0, EventArgs A_1)
	{
		f f2 = new f();
		f2.ShowDialog();
	}
}
