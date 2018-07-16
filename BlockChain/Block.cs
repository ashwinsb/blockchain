using System;
using System.Collections.Generic;
using System.Text;

namespace BlockChain
{
    class Block
    {
        public string hash;
        public string previousHash;
        public string data;
        private string timeStamp;

        public Block(string data, string previousHash)
        {
            this.data = data;
            this.previousHash = previousHash;
            timeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();
        }
    }
}
