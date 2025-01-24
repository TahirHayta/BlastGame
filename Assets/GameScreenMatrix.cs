using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class GameScreenMatrix : MonoBehaviour
{ // ONLY FUNCTIONS ABOUT INT MATRIX
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
    public float blastablitiyFactor; // new blocks will appear according to this factor. Higher this is, higher blastable newcomers.

    public GameScreenMatrix(int width, int height, difficulty difficultyLevel)
    {
        this.width = width;
        this.height = height;
        this.difficultyLevel = difficultyLevel;
        intMatrix = new int[width, height];
        additionalInitializations(width, height, difficultyLevel);
        initializeIntMatrix();
    }

    public void additionalInitializations(int width, int height, difficulty difficultyLevel)
    {
        //TODO minBlastableBlocks will be decided according to how hard 

        //TODO blastablitiyFactor will be decided according to how hard 
    }

    public void initializeIntMatrix()
    {
        //TODO Firstly, bottom line will be filled.

        //TODO as we go up, new blocks will be added according to blastablitiyFactor.

        //TODO after completing 1/4 of the matrix, we will leave the rest of the work to fulfillIntMatrix() method to prevent deadlock situations.
        fulfillIntMatrix();
        
    }

    
    // Prevents deadlock situations. It is being called in a part of beginning and the rest.
    public void fulfillIntMatrix()
    {
        //TODO Firstly, blocks will fall down.

        /*TODO First compare minBlastableBlocks with blastableBlocks. According to the difference, create a new int certainBlastability. 
        It is used to decide how many blocks will be blastable certainly.
        as we go up to fulfill remainings, new blocks will be added according to blastablitiyFactor.*/
    }


    


}
