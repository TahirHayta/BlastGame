using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class GameScreenMatrix : MonoBehaviour
{
    public int width;
    public int height;
    public enum difficulty { easy, medium, hard };
    public difficulty difficultyLevel;
    public int[,] intMatrix; /*
    1 to 6 for colors.
    deciding which icon for blocks to can be checked from here whenever new blocks will appear.
    which new blocks will appear also will be decided from here.
    So, preventing deadlock situations can also be implemented on this matrix. 
    */
    public Block[,] blockMatrix;

    public int minBlastableBlocks;// to prevent deadlock situations. Min that much blastable blocks must exist.
    public int blastableBlocks;/* remaining blastable blocks after a blast. 
    If it is less than minBlastableBlocks, intMatrix will be updated accordingly.
    */

    public GameScreenMatrix(int width, int height, difficulty difficultyLevel)
    {
        this.width = width;
        this.height = height;
        this.difficultyLevel = difficultyLevel;
        intMatrix = new int[width, height];
        decideMinBlastableBlocks(width, height, difficultyLevel);
        
        //blockMatrix = new Block[width, height]; TODO
    }

    public void decideMinBlastableBlocks(int width, int height, difficulty difficultyLevel)
    {
        // will be decided according to how hard 
        //TODO
    }


}
