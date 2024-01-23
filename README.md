# PyramidSolver
Solution to get maximum path sum for random pyramid data structure.

Pyramid type is a data structure for representation of inverted pyramids like this.

    [00059] [00207] [00098] [00095]
        [00087] [00001] [00070]
            [00036] [00041]
                [00023]
 
The maximal sum of this pyramid is 353.
The maximal path is [03,00], [02,00], [01,00], [00,01].

You could also imagine same data like this array.

    [00059] [00207] [00098] [00095]
    [00087] [00001] [00070] [     ]
    [00036] [00041] [     ] [     ]
    [00023] [     ] [     ] [     ]

Therefore addressing looks like this [row][column].

     [00,00] [00,01] [00,02] [00,03]
         [01,00] [01,01] [01,02]
             [02,00] [02,01]
                 [03,00]
