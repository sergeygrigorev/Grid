using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hello
{
	public partial class Default : System.Web.UI.Page
	{
		private int max, columns;
		private int rowsn = 20;

		protected global::System.Web.UI.WebControls.Button btn0;
		protected global::System.Web.UI.WebControls.Button btn1;
		protected global::System.Web.UI.WebControls.Button btn2;
		protected global::System.Web.UI.WebControls.Button btn3;
		protected global::System.Web.UI.WebControls.Button btn4;
		Button[] btns = new Button[5];

		protected void Page_Load(object sender, EventArgs e)
		{
			int i, j;
			TableRow c;

			

			MainClass.init();
			i = MainClass.a.Count;
			columns = MainClass.a[0].Count();
			max = i - (i%rowsn) - 1;
			
			t.Rows.Clear();
			for (i = 0; i <= rowsn; i++)
			{
				c = new TableRow();
				for (j = 0; j < columns; j++)
					c.Cells.Add(new TableCell());
				t.Rows.Add(c);
			}
			btn0 = new Button();
			btn1 = new Button();
			btn2 = new Button();
			btn3 = new Button();
			btn4 = new Button();
			btns[0] = btn0;
			btns[1] = btn1;
			btns[2] = btn2;
			btns[3] = btn3;
			btns[4] = btn4;
			btn0.Click += buttonsClick;
			btn1.Click += buttonsClick;
			btn2.Click += buttonsClick;
			btn3.Click += buttonsClick;
			btn4.Click += buttonsClick;
			btn0.ID = "b0";
			btn1.ID = "b1";
			btn2.ID = "b2";
			btn3.ID = "b3";
			btn4.ID = "b4";
			t.Rows[0].Cells[0].Controls.Add(btn0);
			t.Rows[0].Cells[1].Controls.Add(btn1);
			t.Rows[0].Cells[2].Controls.Add(btn2);
			t.Rows[0].Cells[3].Controls.Add(btn3);
			t.Rows[0].Cells[4].Controls.Add(btn4);
			tableRefresh();
			if (MainClass.col1 == MainClass.col2)
				btns[MainClass.col1].Text = "both";
			else
			{
				btns[MainClass.col1].Text = "1";
				btns[MainClass.col2].Text = "2";
			}
		}

		protected void tableRefresh()
		{
			int i, j;
			TableRow c;

			Label1.Text = MainClass.start.ToString();

			for (i=0;i<rowsn;i++)
			{
				c = t.Rows[i+1];
				for (j = 0; j < columns; j++)
					c.Cells[j].Text = MainClass.a[i + MainClass.start][j].ToString();
			}
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			if (MainClass.start > 0)
				MainClass.start -= rowsn;
			tableRefresh();
		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			if (MainClass.start < max)
				MainClass.start += rowsn;
			tableRefresh();
		}

		protected void buttonsClick (object sender, EventArgs e)
		{
			global::System.Web.UI.WebControls.Button b = (global::System.Web.UI.WebControls.Button) sender;
			int i;

			btns[MainClass.col1].Text = "";
			btns[MainClass.col2].Text = "1";
			MainClass.col1 = MainClass.col2;
			for (i=0;i<5;i++)
				if (b == btns[i])
					break;
			MainClass.col2 = i;
			btns[i].Text = (MainClass.col1 == MainClass.col2) ? "both" : "2";

			MainClass.a.Sort(new Comparison<int[]>(MainClass.compareThem));
			tableRefresh();
		}
	}
}