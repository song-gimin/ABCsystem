using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABCsystem.Core;

namespace ABCsystem.Algorithm
{
    public class DrawInspectInfo    // 검사 결과를 그리기 위한 정보 클래스
    {
        public Rect rect;
        public DecisionType decision; // 검사 결과 타입
    }
}
