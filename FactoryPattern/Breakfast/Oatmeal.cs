using System;

namespace FactoryPattern.Breakfast {
    public class Oatmeal : IBreakfast {

        public int CookTime { get; }

        public Oatmeal() {
            CookTime = 5;
        }

        public string GetFood() => "Oatmeal";
    }
}
