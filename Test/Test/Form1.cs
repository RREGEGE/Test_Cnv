using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Test.Form1;
using Org.BouncyCastle.Utilities;


namespace Test
{

    public partial class Form1 : Form
    {
        private List<CustomRectangle> rectangles; // 사각형 리스트
        private CustomRectangle selectedRectangle; // 선택된 사각형
        public Form1()
        {
            InitializeComponent();
            rectangles = new List<CustomRectangle>(); // 사각형 리스트 초기화
        }
        

        // Panel의 Paint 이벤트
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // 모든 사각형 그리기
            foreach (var rectangle in rectangles)
            {
                rectangle.Draw(e.Graphics);
            }
            // 선택된 사각형 강조
            DrawSelectedRectangle(e.Graphics);
        }

        // Apply 버튼 클릭 이벤트
        private void btnApply_Click(object sender, EventArgs e)
        {
            int x, y, id;

            // TextBox에서 좌표값과 ID 받아오기
            if (int.TryParse(tboxX.Text, out x) && int.TryParse(tboxY.Text, out y) && int.TryParse(tboxID.Text, out id))
            {
                CustomRectangle customRectangle = null;

                // ComboBox에서 선택된 값 확인
                string selectedType = cboxType.SelectedItem.ToString();

                // 선택된 값에 따라 객체 생성
                switch (selectedType)
                {
                    case "InterFace":
                        customRectangle = new Interface(x, y, id); // Interface 객체 생성 및 ID 전달
                        break;
                    //case "Normal":
                    //    customRectangle = new Normal(x, y, id); // Normal 객체 생성 및 ID 전달
                    //    break;
                    //case "Turn":
                    //    customRectangle = new Turn(x, y, id); // Turn 객체 생성 및 ID 전달
                    //    break;
                    //case "Long_1":
                    //    customRectangle = new Long_1(x, y, id); // Long_1 객체 생성 및 ID 전달
                    //    break;
                    //case "Long_2":
                    //    customRectangle = new Long_2(x, y, id); // Long_2 객체 생성 및 ID 전달
                    //    break;
                    default:
                        MessageBox.Show("유효한 타입을 선택해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                if (customRectangle != null)
                {
                    rectangles.Add(customRectangle); // 리스트에 사각형 추가
                    panel1.Invalidate(); // Panel 다시 그리기
                }
            }
            else
            {
                MessageBox.Show("유효한 숫자를 입력해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            // 클릭된 위치에서 사각형을 찾음
            var rectangleClicked = rectangles.FirstOrDefault(rect =>
                e.X >= rect.X && e.X <= rect.X + rect.Width &&
                e.Y >= rect.Y && e.Y <= rect.Y + rect.Height);

            if (rectangleClicked != null)
            {
                // 선택된 사각형을 변경
                selectedRectangle = rectangleClicked;

                // DataGridView에 선택된 사각형의 ID와 타입 업데이트
                UpdateStatusGrid();
            }
            else
            {
                // 사각형이 클릭되지 않은 경우 선택 해제
                selectedRectangle = null;
                dgStatus.Rows.Clear(); // 선택 해제 시 DataGridView 비우기
            }

            panel1.Invalidate(); // Panel 다시 그리기
        }
        private void UpdateStatusGrid()
        {
            dgStatus.Rows.Clear(); // 이전 데이터 지우기

            if (selectedRectangle != null)
            {
                dgStatus.Rows.Add(selectedRectangle.ID, selectedRectangle.Type); // ID와 타입 추가
            }
        }
        // Panel의 Paint 이벤트에서 선택된 사각형 강조
        private void DrawSelectedRectangle(Graphics g)
        {
            if (selectedRectangle != null)
            {
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    g.DrawRectangle(pen, selectedRectangle.X, selectedRectangle.Y, selectedRectangle.Width, selectedRectangle.Height);
                }
            }
        }

    }
}
