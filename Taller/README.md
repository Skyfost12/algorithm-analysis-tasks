## 56. Merge Intervals
 
Enlace: https://leetcode.com/problems/merge-intervals/
Código: [`merge-intervals/Solution.cs`](merge-intervals/Solution.cs)
 
**Familia:** ordenamiento  
**Idea:** la clave es el extremo izquierdo (`start`). Se ordenan los intervalos por `start` y luego una sola pasada mantiene el intervalo «abierto» actual: si el siguiente empieza antes o justo cuando termina el actual (`start <= end`), se ensancha el `end` con el máximo; si no, se cierra el actual y se abre otro. Es el `merge` del laboratorio, pero sobre una sola corrida.  
**Complejidad:** con `n` intervalos, tiempo `O(n log n)` (domina el sort; la pasada es `O(n)`) y espacio `O(n)` para la salida (más `O(log n)` de pila del sort).
 
![Accepted — Merge Intervals](evidencias/merge-intervals-accepted.png)