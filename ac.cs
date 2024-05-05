using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

public class ac : Form
{
	private u m_a;

	private Label[] m_b;

	private int c;

	private int d;

	private Color e;

	private string f;

	private bool g = true;

	private IContainer h;

	private Label i;

	private Panel j;

	private Panel k;

	private Panel l;

	private Panel m;

	private Panel n;

	private Panel o;

	public ac(u A_0, string A_1, string[] A_2)
	{
		a();
		this.m_a = A_0;
		f = A_1;
		d = A_2.Length - 1;
		e = Color.FromArgb(190, 190, 190);
		this.m_b = new Label[A_2.Length];
		int num = 0;
		int num2 = 0;
		for (int num3 = 0; num3 < A_2.Length; num3++)
		{
			this.m_b[num3] = new Label();
			this.m_b[num3].Name = "Labe" + num3.ToString(CultureInfo.InvariantCulture);
			this.m_b[num3].AutoSize = true;
			this.m_b[num3].Text = A_2[num3];
			this.m_b[num3].Location = new Point(num, num2);
			m.Controls.Add(this.m_b[num3]);
			num2 += 32;
		}
		int num4 = Array.IndexOf(A_2, f);
		if (num4 != -1 && num4 <= d)
		{
			c = num4;
		}
		b();
	}

	private void b()
	{
		Label[] array = this.m_b;
		foreach (Label label in array)
		{
			label.ForeColor = e;
		}
		this.m_b[c].ForeColor = Color.White;
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Escape)
		{
			this.m_a.m = f;
			g = false;
			Close();
		}
		else if (A_1.KeyCode == Keys.Return)
		{
			this.m_a.m = this.m_b[c].Text;
			g = false;
			Close();
		}
		else if (A_1.KeyCode == Keys.Up)
		{
			if (c > 0)
			{
				c--;
			}
			else
			{
				c = d;
			}
			b();
		}
		else if (A_1.KeyCode == Keys.Down)
		{
			if (c < d)
			{
				c++;
			}
			else
			{
				c = 0;
			}
			b();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = g;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && h != null)
		{
			h.Dispose();
		}
		base.Dispose(disposing);
	}

	private void a()
	{
		i = new Label();
		j = new Panel();
		k = new Panel();
		l = new Panel();
		m = new Panel();
		n = new Panel();
		o = new Panel();
		SuspendLayout();
		i.Anchor = AnchorStyles.Top;
		i.AutoSize = true;
		i.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		i.Location = new Point(113, 1);
		i.Name = "Options_Label";
		i.Size = new Size(125, 34);
		i.TabIndex = 7;
		i.Text = "Options";
		j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		j.BackColor = Color.FromArgb(190, 190, 190);
		j.Location = new Point(288, 22);
		j.Name = "Goriz2";
		j.Size = new Size(50, 3);
		j.TabIndex = 1;
		k.BackColor = Color.FromArgb(190, 190, 190);
		k.Location = new Point(12, 22);
		k.Name = "Goriz1";
		k.Size = new Size(50, 3);
		k.TabIndex = 2;
		l.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		l.BackColor = Color.FromArgb(190, 190, 190);
		l.Location = new Point(12, 115);
		l.Name = "Goriz3";
		l.Size = new Size(326, 3);
		l.TabIndex = 3;
		m.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		m.AutoScroll = true;
		m.AutoSize = true;
		m.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		m.Location = new Point(30, 40);
		m.MaximumSize = new Size(690, 510);
		m.MinimumSize = new Size(286, 60);
		m.Name = "Centr_Panel";
		m.Size = new Size(286, 60);
		m.TabIndex = 4;
		n.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		n.BackColor = Color.FromArgb(190, 190, 190);
		n.Location = new Point(12, 22);
		n.Name = "Vert1";
		n.Size = new Size(3, 95);
		n.TabIndex = 5;
		o.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		o.BackColor = Color.FromArgb(190, 190, 190);
		o.Location = new Point(335, 22);
		o.Name = "Vert2";
		o.Size = new Size(3, 95);
		o.TabIndex = 6;
		base.AutoScaleDimensions = new SizeF(19f, 37f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		BackColor = Color.FromArgb(27, 35, 165);
		base.ClientSize = new Size(350, 140);
		base.Controls.Add(o);
		base.Controls.Add(m);
		base.Controls.Add(j);
		base.Controls.Add(i);
		base.Controls.Add(n);
		base.Controls.Add(l);
		base.Controls.Add(k);
		Font = new Font("Arial", 24f, FontStyle.Bold, GraphicsUnit.Point, 204);
		ForeColor = Color.FromArgb(190, 190, 190);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(10, 9, 10, 9);
		MaximumSize = new Size(750, 580);
		MinimumSize = new Size(350, 140);
		base.Name = "Option_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Option_Form";
		base.FormClosing += a;
		base.KeyDown += a;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
