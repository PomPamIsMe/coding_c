#include <stdio.h>

int main() {
    int j,i,temp;
    int arr1[5] ={30,40,10,50,20};
    int arr2[5] ={40,30,20,10,50};
    
    for(i=0; i<=4; i++){
      for(j=i+1; j<=4; j++){
          if(arr1[i]>arr1[j]){
            temp = arr1[i];
            arr1[i] = arr1[j];
            arr1[j] = temp;
          }
          
      }}
      for(i=0; i<=4; i++){
         printf("%d\t",arr1[i]);
      }
      
      printf("\n");
      
      for(i=0; i<=4; i++){
      for(j=i+1; j<=4; j++){
          if(arr1[i]<arr1[j]){
            temp = arr1[i];
            arr1[i] = arr1[j];
            arr1[j] = temp;
          }
          
      }}
      for(i=0; i<=4; i++){
         printf("%d\t",arr1[i]);
      }
      
    return 0;
}