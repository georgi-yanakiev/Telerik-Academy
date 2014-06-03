using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace FallingWordsGame
{
    public class Game
    {
        private Painter painter;         // Object that paints(writes) on the screen
        private Keyboard keyboard;       // KeyBoard interface
        private List<GameObject> activeObjects;  // Words currently in the screen
        private GameObject selectedObject;
        private WordReader reader;
        private SingleLineText scoreObject;
        private MultiLineText bossObject;
        public WordGenerator generator;
        public static int viewFieldWidth;
        private int points;
        private bool inBossFight;
        private List<string[]> bossBlocksDataBase;
        private int LivesLeft;
        SoundPlayer typing = new SoundPlayer(@"..\..\Sounds\KeyStroke.wav");
        //SoundPlayer typing = new SoundPlayer(@"KeyStroke.wav");
        SoundPlayer bossFight = new SoundPlayer(@"..\..\Sounds\BossFight.wav"); // intro sound of the boss fight
        //SoundPlayer bossFight = new SoundPlayer(@"BossFight.wav");

        public Game(Keyboard keyBoard)
        {
            LivesLeft = 5;
            viewFieldWidth = Console.WindowWidth - 1;
            activeObjects = new List<GameObject>();
            painter = new Painter(Console.WindowHeight - 1, viewFieldWidth);
            bossBlocksDataBase = new List<string[]>();
            BlockReader bossReader = new BlockReader(@"..\...\TextFiles\Boss.txt");
            //BlockReader bossReader = new BlockReader(@"Boss.txt");
            while (!bossReader.End()) //This shoul be in another class but we dont have time
            {
                bossBlocksDataBase.Add(bossReader.NextBlock());
            }
            scoreObject = new SingleLineText("Score: 0", new Coordinates(3, Console.WindowWidth - 10));
            reader = new WordReader(@"..\..\TextFiles\WordsDictionary.txt"); 
            //reader = new WordReader(@"WordsDictionary.txt");
            generator = new WordGenerator(CreateWordDataBase());
            this.keyboard = keyBoard;
            selectedObject = null;
            inBossFight = false;
            points = 0;
        }

        private void AddWord(GameObject obj)
        {
            activeObjects.Add(obj);
        }
 
        public void OnSpacePressed()
        {
            if (FallingWordsMain.SoundOn)
            {
                typing.Play();
            }
            if (selectedObject != null && selectedObject.GetFirstNotDestroyed() != null)
            {
                if (WordManipulator.IsCurrentSpace(selectedObject.GetFirstNotDestroyed()))
                {
                    WordManipulator.ChangeSpace(selectedObject.GetFirstNotDestroyed());
                }
                else
                {
                    WordManipulator.UndoChanges(selectedObject.GetFirstNotDestroyed());
                    selectedObject = null;
                }
            }
        }

        public void OnLetterPressed(char pressedChar)
        {
            if (FallingWordsMain.SoundOn)
            {
                typing.Play();
            }
            if (selectedObject == null || selectedObject.ToDestroyFlag == true)
            {
                SelectWord(pressedChar);
                if (selectedObject != null && selectedObject.GetFirstNotDestroyed() != null)
                {
                    WordManipulator.MakeFirstLowerToUpperChar(selectedObject.GetFirstNotDestroyed());
                }
            }
            else
            {
                if (WordManipulator.MatchFirstLowerChar(selectedObject.GetFirstNotDestroyed(), pressedChar))
                {
                    WordManipulator.MakeFirstLowerToUpperChar(selectedObject.GetFirstNotDestroyed());
                }
                else
                {
                    WordManipulator.UndoChanges(selectedObject.GetFirstNotDestroyed());
                    selectedObject = null;
                }
            }
        }

        private void SelectWord(char inputChar)
        {
            foreach (GameObject item in activeObjects)
            {
                Word firstNotDestroyed = item.GetFirstNotDestroyed();
                if (firstNotDestroyed != null && WordManipulator.MatchFirstLowerChar(firstNotDestroyed, inputChar))
                {
                    selectedObject = item;
                    break;
                }
            }
            //selectedObject = null;
        }

        private int enteringBossFightLimit = 11;
        
        private int TickTime = 10;

        public void Start()
        {
            int linesCounter = 0;
            int skippedLinesAfterAddingWord = 2;
            while (true)
            {
                painter.PrintField();

                if (inBossFight && activeObjects.Count == 0)
                {
                    TickTime = 6;
                    inBossFight = false;
                }
                if (points % enteringBossFightLimit == (enteringBossFightLimit - 1))
                {
                    TickTime = 20;
                    inBossFight = true;
                }

                if (TickOnGivenLoop(TickTime))
                {
                    
                    MoveActiveObjects();
                    if (inBossFight)
                    {
                        BossFight();
                    }
                    else
                    {
                        JustEnteringInBossFight = true;
                        if (++linesCounter == skippedLinesAfterAddingWord)
                        {
                            SingleLineText line = new SingleLineText(generator.NewWord());
                            activeObjects.Add(line);
                            linesCounter = 0;
                        }
                    }
                    
                }
                System.Threading.Thread.Sleep(10);
                keyboard.ProcessInput();
                painter.ClearField();
                Console.Clear();
                painter.InsertIntoField(LivesLeftLine());
                painter.InsertIntoField(scoreObject);
                RemoveInactiveWords();
                if(LivesLeft < 0)
                {
                    break;
                }
            }
        }

        private int counter = 0;

        private bool TickOnGivenLoop(int n)
        {
            counter++;
            if (counter % n == 0)
            {
                counter = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        private int IncreaseScore()
        {
            points += 1;
            return points;
        }

        private void CreateScoreObject()
        {
            string score = "Score: " + points;
            scoreObject = new SingleLineText(score, new Coordinates(3, Console.WindowWidth - 10));
        }

        private void BossScreen()
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n");
            Console.WriteLine("\t" + @"  ____   ____   _____ _____   ______ _____ _____ _    _ _______ ");
            Console.WriteLine("\t" + @" |  _ \ / __ \ / ____/ ____| |  ____|_   _/ ____| |  | |__   __|");
            Console.WriteLine("\t" + @" | |_) | |  | | (___| (___   | |__    | || |  __| |__| |  | |   ");
            Console.WriteLine("\t" + @" |  _ <| |  | |\___ \\___ \  |  __|   | || | |_ |  __  |  | |   ");
            Console.WriteLine("\t" + @" | |_) | |__| |____) |___) | | |     _| || |__| | |  | |  | |   ");
            Console.WriteLine("\t" + @" |____/ \____/ \____/\____/  |_|    |_____\_____|_|  |_|  |_|   ");
        }

        private bool JustEnteringInBossFight = true;

        private void BossFight()
        {
            if (JustEnteringInBossFight)
            {
                Console.Clear(); activeObjects.Clear();
                BossScreen();
                if (FallingWordsMain.SoundOn)
                {
                    int bossSoundCounter = 0;
                    while (bossSoundCounter++ < 2)
                    {
                        bossFight.PlaySync();
                    }
                }
                else
                {
                    System.Threading.Thread.Sleep(2000);
                }

                List<GameObject> bossList = new List<GameObject>();
                bossObject = new MultiLineText(bossBlocksDataBase[(new Random()).Next(0, bossBlocksDataBase.Count)]);
                activeObjects.Add(bossObject);
                JustEnteringInBossFight = false;
            }
            
        }

        private void RemoveInactiveWords()
        {
            //Handle the situation if there is completed word inside the selected GameObject
            if (selectedObject != null && selectedObject.GetFirstNotDestroyed() != null && WordManipulator.IsWholeWordToUpper(selectedObject.GetFirstNotDestroyed()))
            {
                int selectedWordsBodyLength = selectedObject.GetValueAsListOfWords().Count;
                selectedObject.GetFirstNotDestroyed().IsGuessed = true;
                IncreaseScore();
                CreateScoreObject();
                selectedObject.RemoveIfDestroyed();
                selectedObject = null;
            }
            bool wordHasFallen = false;
            //Check every active object in ActiveObjects
            foreach (GameObject gm in activeObjects)
            {
                foreach (Word word in gm.GetValueAsListOfWords())
                {
                    if (word.GetPosition().posX == Console.WindowHeight - 2)
                    {
                        selectedObject = null;
                        wordHasFallen = true;                      
                    }
                }
                gm.RemoveIfDestroyed();
                painter.InsertIntoField(gm);
            }
            if (wordHasFallen && !inBossFight)
            {
                activeObjects.Clear();
                LivesLeft--;
            }
            else
            {
                activeObjects.RemoveAll(x => x.ToDestroyFlag);
            }
        }

        private void MoveActiveObjects()
        {
            foreach (GameObject obj in activeObjects)
            {
                obj.Move();
            }
        }

        private string[] CreateWordDataBase()
        {
            List<string> list = new List<string>();
            while (!reader.End())
            {
                string line = reader.NextWord();
                list.Add(line);
            }
            return list.ToArray();
        }

        private SingleLineText LivesLeftLine()
        {
            string livesLeftString = "Lives: " + LivesLeft.ToString();
            SingleLineText lives = new SingleLineText(livesLeftString, new Coordinates(5,Console.WindowWidth - 10));
            return lives;
        }
    }
}
