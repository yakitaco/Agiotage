using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agiotage {

    public enum sType {
        BUY,    // 買
        SELL,   // 売
    }

    class Stack {
        static int outstanding; // 発行数
        static int price; //株価
        static int appraised;   // 評価価格
        sType st;
        int value;
        int number;
    }
}
