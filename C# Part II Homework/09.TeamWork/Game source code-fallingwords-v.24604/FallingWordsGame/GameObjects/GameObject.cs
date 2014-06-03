using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingWordsGame
{
    public abstract class GameObject : Interfaces.IMovable, Interfaces.IPrintable
    {
        protected List<Word> body;

        public bool ToDestroyFlag;

        public GameObject()
        {
            body = new List<Word>();
            ToDestroyFlag = false;
        }

        public abstract void Move();

        public Word GetFirstNotDestroyed()
        {
            foreach (Word item in body)
            {
                if (!item.IsGuessed)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Word> GetValueAsListOfWords()
        {
            return body;
        }

        public void RemoveIfDestroyed()
        {
            body.RemoveAll(x => x.Position.posX == 29);
            int cnt = 0;
            for (int i = 0; i < body.Count; i++)
            {
                if(body[i].IsGuessed)
                {
                    cnt++;
                }
            }
            if(body.Count == cnt)
            {
                ToDestroyFlag = true;
            }
            
        }
    }
}
