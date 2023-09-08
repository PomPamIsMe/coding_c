#include <stdio.h>

int main() {
    int i,arr[4];
    for(i=0; i<=4; i++){
        printf("Input Number[%d]:",i);
        scanf("%d",&arr[i]);
        
        printf("Array[%d] = %d\n",i,arr[i]);
    }
    return 0;
}