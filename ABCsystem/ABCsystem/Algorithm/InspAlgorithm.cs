using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace ABCsystem.Algorithm
{
    public enum InspectType
    {
        InspNone = -1,
    }
    public abstract class InspAlgorithm
    {
        //알고리즘 타입 정의
        public InspectType InspectType { get; set; } = InspectType.InspNone;
       
        //#8_INSPECT_BINARY#1 검사할 영역 정보를 저장하는 변수
        public Rect TeachRect { get; set; } 
        public Rect InspRect { get; set; }

        //검사할 원본 이미지
        protected Mat _srcImage = null;

        public abstract bool DoInspect();   //검사 수행 메서드


        public virtual int GetResultRect(out List<DrawInspectInfo> resultArea)  //검사 결과 영역 반환 메서드
        {
            resultArea = null;
            return 0;
        }
    }
}
