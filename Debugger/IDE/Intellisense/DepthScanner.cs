﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugger.IDE.Intellisense {
    
    //Scans a file and marks the { brace } depth to tell intellisense how many braces it's allowed to go up in looking resolving a name
    public class DepthScanner {
        int[] backing_;

        public int GetBraceDepth(int aLine) {
            if (aLine >= 0 && aLine < backing_.Length)
                return backing_[aLine];
            return -1;
        }

        public void Process(string code) {
            string[] lines = code.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            backing_ = new int[lines.Length];

            int depth = 0;
            for (int i = 0; i < lines.Length; ++i) {
                backing_[i] = depth;
                if (lines[i].Contains('{'))
                    ++depth;
                else if (lines[i].Contains('}'))
                    --depth;
            }
        }
    }
}
