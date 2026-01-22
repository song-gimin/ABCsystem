using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABCsystem.Algorithm;
using ABCsystem.Core;
using OpenCvSharp;

namespace ABCsystem.Teach
{
    public class InspWindow //ROI 윈도우 정보를 담는 클래스
    {
        public InspWindowType InspWindowType { get; set; }

        public string Name { get; set; }
        public string UID { get; set; }

        public Rect WindowArea { get; set; }

        public bool IsTeach { get; set; } = false;

        public List<InspAlgorithm> AlgorithmList { get; set; } = new List<InspAlgorithm>();


        public InspWindow()
        {
        }

        public InspWindow(InspWindowType windowType, string name)   //생성자
        {
            InspWindowType = windowType;
            Name = name;
        }

        public bool AddInspAlgorithm(InspectType inspType)  //알고리즘 추가 메서드
        {
            InspAlgorithm inspAlgo = null;

            if (inspAlgo is null)
                return false;

            AlgorithmList.Add(inspAlgo);

            return true;
        }

        public virtual bool OffsetMove(OpenCvSharp.Point offset)    //윈도우 이동 메서드
        {
            Rect windowRect = WindowArea;
            windowRect.X += offset.X;
            windowRect.Y += offset.Y;
            WindowArea = windowRect;
            return true;
        }
    }
}
