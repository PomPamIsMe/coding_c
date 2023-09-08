#include <stdio.h>

int main() {
    int i,temp;
    int arr1[5] ={10,20,30,40,50};
    int arr2[5] ={50,40,30,20,10};
    
    for(i=0; i<=4; i++){
        if(arr1[i]>arr2[i]){
        
           temp = arr1[i];
           arr1[i] = arr2[i];
           arr2[i] = temp;
    }
        printf("%d %d\n",arr1[i],arr2[i]);
    }
    return 0;
}