#include <stdio.h>

int main() {
    int i,min,max;
    int arr1[5] ={10,20,30,40,50};
    int arr2[5] ={50,40,30,20,10};
    
    for(i=0; i<=4; i++){
        
        min = arr1[0];
        if(min>arr1[i]){
            min=arr1[i];
            
        }
        
        max = arr2[0];
        if(max<arr2[i]){
            max=arr2[i];
        }
        printf("%d %d\n",arr1[i],arr2[i]);

    }
        printf("min is %d\n",min);
        printf("max is %d",max);

    return 0;
}