#include <stdio.h>

int main() {
    int i,arr[4],sum;
    for(i=0; i<=4; i++){
        printf("Input Number[%d]:",i);
        scanf("%d",&arr[i]);
        
         sum = sum+arr[i];
         printf("Array[%d] = %d\n",i,arr[i]); 
    }
         printf("Sum = %d\n",sum);
    return 0;
}