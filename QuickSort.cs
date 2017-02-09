public static void QuickSortArr(int[] input, int left, int right)
{
	//if array is not sorted
	if(left < right)
	{	
		//gather new partition value
		int partition = PartitionArr(input, left, right);
		//recursively sort the left partition
		QuickSortArr(input, left, partition-1);
		//recursively sort the right partition
		QuickSortArr(input, partition + 1, right);
	}
}


public static int PartitionArr(int[] input, int left, int right) 
{
	//establish pivot point (in this version - will always be the last value in array
	int pivot = input[right];
	
	//establish temp value for partitioning arr
	int temp = 0;
	
	//initalize iterator that refers to left value
	int i = left;
	
	//iterate through array and partition
	for(int j = left; j < right; j++)
	{	
		//if the left side value is less than the pivot value
		if(input[j] < pivot)
		{
			temp = input[j];
			input[j] = input[i];
			input[i] = temp;
			i++; //increment i along with j
		}
	}
	input[right] = input[i]; //reset the far right value of partition
	input[i] = pivot; //create new pivot point equal to a full incremented 'i'
	
	return i;
}
