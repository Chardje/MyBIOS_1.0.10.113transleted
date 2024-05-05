using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class o : Form
{
	private u m_a;

	private v b;

	private bool c = true;

	private IContainer d;

	private PictureBox e;

	private PictureBox f;

	private Panel g;

	private Panel h;

	private PictureBox i;

	private Panel j;

	private Panel k;

	private Panel l;

	private Panel m;

	private Panel n;

	private Panel m_o;

	private Label p;

	private Label q;

	private Label r;

	private Label s;

	private Label t;

	private Label u;

	public o(u A_0)
	{
		this.m_a = A_0;
		a();
		u.Text = this.m_a.ia;
		t.Text = this.m_a.p;
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Escape)
		{
			c = false;
			Close();
		}
		else if (A_1.KeyCode == Keys.Return)
		{
			b = new v(this.m_a);
			b.ShowDialog();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			this.m_a.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			this.m_a.na();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			this.m_a.nd();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			this.m_a.l();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = c;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && d != null)
		{
			d.Dispose();
		}
		base.Dispose(disposing);
	}

	private void a()
	{
		g = new Panel();
		s = new Label();
		r = new Label();
		q = new Label();
		p = new Label();
		m_o = new Panel();
		h = new Panel();
		t = new Label();
		u = new Label();
		j = new Panel();
		k = new Panel();
		l = new Panel();
		m = new Panel();
		n = new Panel();
		i = new PictureBox();
		f = new PictureBox();
		e = new PictureBox();
		g.SuspendLayout();
		h.SuspendLayout();
		((ISupportInitialize)i).BeginInit();
		((ISupportInitialize)f).BeginInit();
		((ISupportInitialize)e).BeginInit();
		SuspendLayout();
		g.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		g.AutoScroll = true;
		g.BackColor = Color.FromArgb(190, 190, 190);
		g.Controls.Add(s);
		g.Controls.Add(r);
		g.Controls.Add(q);
		g.Controls.Add(p);
		g.Controls.Add(m_o);
		g.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		g.ForeColor = Color.FromArgb(27, 35, 165);
		g.Location = new Point(12, 92);
		g.Name = "Lev_Panel";
		g.Size = new Size(868, 877);
		g.TabIndex = 2;
		s.AutoSize = true;
		s.ForeColor = Color.White;
		s.Location = new Point(22, 193);
		s.Name = "NorthBridgeConfiguration";
		s.Size = new Size(429, 34);
		s.TabIndex = 38;
		s.Text = "► North Bridge Configuration";
		r.AutoSize = true;
		r.ForeColor = Color.Black;
		r.Location = new Point(22, 87);
		r.Name = "Warning_INFO";
		r.Size = new Size(163, 34);
		r.TabIndex = 37;
		r.Text = "WARNING:";
		q.AutoSize = true;
		q.ForeColor = Color.Black;
		q.Location = new Point(181, 87);
		q.Name = "Warning_INFO_Value";
		q.Size = new Size(560, 68);
		q.TabIndex = 36;
		q.Text = "Setting wrong values in below sections\r\nmay cause system to malfunction.";
		p.AutoSize = true;
		p.ForeColor = Color.Black;
		p.Location = new Point(22, 17);
		p.Name = "AdvancedChipsetSettings_shapka";
		p.Size = new Size(391, 34);
		p.TabIndex = 35;
		p.Text = "Advanced Chipset Settings";
		m_o.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		m_o.BackColor = Color.FromArgb(27, 35, 165);
		m_o.Location = new Point(18, 68);
		m_o.Name = "Goriz_1";
		m_o.Size = new Size(828, 2);
		m_o.TabIndex = 1;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		h.AutoScroll = true;
		h.Controls.Add(t);
		h.Controls.Add(u);
		h.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		h.ForeColor = Color.FromArgb(27, 35, 165);
		h.Location = new Point(884, 92);
		h.Name = "Prav_Panel";
		h.Size = new Size(382, 877);
		h.TabIndex = 3;
		t.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		t.Location = new Point(6, 590);
		t.Name = "Help_Niz";
		t.Size = new Size(372, 250);
		t.TabIndex = 1;
		u.Location = new Point(6, 15);
		u.Name = "Help_Verh";
		u.Size = new Size(372, 470);
		u.TabIndex = 0;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		j.BackColor = Color.FromArgb(27, 35, 165);
		j.Location = new Point(10, 90);
		j.Name = "Goriz1";
		j.Size = new Size(1260, 2);
		j.TabIndex = 0;
		k.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		k.BackColor = Color.FromArgb(27, 35, 165);
		k.Location = new Point(10, 90);
		k.Name = "Vert1";
		k.Size = new Size(4, 879);
		k.TabIndex = 0;
		l.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		l.BackColor = Color.FromArgb(27, 35, 165);
		l.Location = new Point(880, 90);
		l.Name = "Vert2";
		l.Size = new Size(4, 879);
		l.TabIndex = 1;
		m.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		m.BackColor = Color.FromArgb(27, 35, 165);
		m.Location = new Point(10, 969);
		m.Name = "Goriz2";
		m.Size = new Size(1260, 2);
		m.TabIndex = 1;
		n.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		n.BackColor = Color.FromArgb(27, 35, 165);
		n.Location = new Point(1266, 90);
		n.Name = "Vert3";
		n.Size = new Size(4, 879);
		n.TabIndex = 2;
		i.Dock = DockStyle.Bottom;
		i.Image = Resources.NizAll;
		i.Location = new Point(0, 989);
		i.Name = "Niz";
		i.Size = new Size(1280, 35);
		i.SizeMode = PictureBoxSizeMode.StretchImage;
		i.TabIndex = 4;
		i.TabStop = false;
		f.Dock = DockStyle.Top;
		f.Image = Resources.AdvancedOnly;
		f.Location = new Point(0, 35);
		f.Name = "VerhMenu";
		f.Size = new Size(1280, 35);
		f.SizeMode = PictureBoxSizeMode.StretchImage;
		f.TabIndex = 1;
		f.TabStop = false;
		e.Dock = DockStyle.Top;
		e.Image = Resources.ShapkaAll;
		e.Location = new Point(0, 0);
		e.Name = "Shapka";
		e.Size = new Size(1280, 35);
		e.SizeMode = PictureBoxSizeMode.StretchImage;
		e.TabIndex = 0;
		e.TabStop = false;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(190, 190, 190);
		base.ClientSize = new Size(1280, 1024);
		base.Controls.Add(m);
		base.Controls.Add(j);
		base.Controls.Add(i);
		base.Controls.Add(f);
		base.Controls.Add(e);
		base.Controls.Add(n);
		base.Controls.Add(l);
		base.Controls.Add(k);
		base.Controls.Add(g);
		base.Controls.Add(h);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Advanced_Chipset_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Advanced_Chipset_Form";
		base.WindowState = FormWindowState.Maximized;
		base.FormClosing += a;
		base.KeyDown += a;
		g.ResumeLayout(performLayout: false);
		g.PerformLayout();
		h.ResumeLayout(performLayout: false);
		((ISupportInitialize)i).EndInit();
		((ISupportInitialize)f).EndInit();
		((ISupportInitialize)e).EndInit();
		ResumeLayout(performLayout: false);
	}
}
