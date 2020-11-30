class Array
{
  void Learn1DArrays()
  {
      int[] ages1  = new int[5]; //{34,14,43};
      ages1[0] = 23;
      ages1[0] = 23;
      ages1[0] = 23;
      ages1[0] = 23;
      ages1[0] = 24;

      int[] ages2 = new int[] {45,23,87};

      decimal[] ages3 = {45,67,23};
  }

  void LearnMDArrays()
  {
      int[,] mulTable  = new int[3,4];
      mulTable[0,0] = 2;

      double[,,] mulTable2 = new double[3,4,2];
      mulTable2[0,0,0] = 2.56;

      byte[,] numbers = { {12,54,53}, {64,87,35} };
  }

void LearnJaggedArrays(){
    int[][] mulTable = new int[3][];
    mulTable[0] = new int[] {2,4};
    mulTable[1] = new int[] {2,4,6};
    mulTable[2] = new int[] {2,4,6,8,10};
}

}