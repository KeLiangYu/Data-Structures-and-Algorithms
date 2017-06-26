# Data-Structures-and-Algorithms

ConsoleApplication1: Honai Tower

題目:<br> 
　　初始狀態下有三根柱子 ,分別為 ABC 三支 ,當中 A 柱擺上將要搬移的碟子 ,碟子由上到下依小到大疊好 ,分別編上號碼 1,2,3,4.... ,需將所有碟子全部搬移到 C 柱 ,規則為大碟不得擺在小碟上 ,也就是數字小者必須在前方<br>
要求: <br>
1.Input : 有幾個環,由上而下為 1,2,.....,N<br>
2.Output: 每一步的動作的結果(輸出的要求是列出每一步驟後 ,各個柱子的情形 ,例:第一步由 A 搬 1 號碟到 C ,輸出便是: A(2,3)B()C(1)) <br>
3.三根柱子由左至右為 A,B,C <br>

example: <br>
    Input : 2 (<-- 此數字為測試資料筆數) <br>
              3 (<-- 第一組測試數字) <br>
              4 (<-- 第二組測試數字) <br>
    Output: A(1,2,3)B()C() (<-- 一開始的初始狀態) <br>
              A(2,3)B()C(1)  (<-- 第一步) <br>
              A(3)B(2)C(1)   (<-- 第二步) <br>
              A(3)B(1,2)C() <br>
              A()B(1,2)C(3) <br>
              A(1)B(2)C(3) <br>
              A(1)B()C(2,3) <br>
              A()B()C(1,2,3) <br><br>
              A(1,2,3,4)B()C() (<-- 一開始的初始狀態) <br>
              A(2,3,4)B(1)C()  (<-- 第一步) <br>
              A(3,4)B(1)C(2)   (<-- 第二步) <br>
              A(3,4)B()C(1,2) <br>
              A(4)B(3)C(1,2) <br>
              A(1,4)B(3)C(2) <br>
              A(1,4)B(2,3)C() <br>
              A(4)B(1,2,3)C() <br>
              A()B(1,2,3)C(4) <br>
              A(1)B(2,3)C(4) <br>
              A(1)B(3)C(2,4) <br>
              A()B(1,3)C(2,4) <br>
              A(2)B(1,3)C(4) <br>
              A(1,2)B(3)C(4) <br>
              A(1,2)B()C(3,4) <br>
              A(2)B(1)C(3,4) <br>
              A()B(1)C(2,3,4) <br>
              A()B()C(1,2,3,4) <br>

ConsoleApplication2: Knight's Tour 

題目: <br>
　　在一個8x8的棋盤中 ,給予一個 Knight 的起始位置 ,經過各位的程式運算後給出 Knight 走過棋盤的所有位置的序列<br>
要求: <br>
1.Input :有幾個 Knight 及每個 Knight 的起始位置<br>
2.Output:棋盤中的每一位置以0~63來表示走的順序<br>
3.為一 8X8 的棋盤 <br>
4.X 和 Y 座標中間以一個space來區隔 <br>
5.output的結果中 ,每個數字亦是以一個space來區隔<br> 

example: <br>
    Input : 2   (<-- 此數字為測試的資料筆數 ,也代表下面有兩列資料代表Knight的起始位置) <br>
              4 4 (<-- 第一個Knight的起始位置) <br>
              0 3 (<-- 第二個Knight的起始位置) <br>
    Output: <br>
              62 57 10 45 24 3 8 5<Enter> <br>
              11 46 63 56 9 6 25 2<Enter> <br>
              58 61 50 47 44 23 4 7<Enter> <br>
              49 12 55 60 51 26 1 22<Enter> <br>
              54 59 48 43 0 33 18 27<Enter> <br>
              13 42 37 52 39 30 21 32<Enter> <br>
              36 53 40 15 34 19 28 17<Enter> <br>
              41 14 35 38 29 16 31 20<Enter> <br>
              <Enter> <br>
              59 18 15 0 53 44 13 10<Enter> <br>
              16 1 60 55 14 11 30 45<Enter> <br>
              19 58 17 52 43 54 9 12<Enter> <br>
              2 63 56 61 36 31 46 29<Enter> <br>
              57 20 51 42 47 40 35 8<Enter> <br>
              50 3 62 23 32 37 28 39<Enter> <br>
              21 24 5 48 41 26 7 34<Enter> <br>
              4 49 22 25 6 33 38 27<Enter> <br>
限制: <br>
*   若有數個位置可以走的話,以右上角順時針方向為優先 
*   請不要加上不必要的空白和<Enter>,以免造成不必要的檢查錯誤 
*   Output file 的內容為ASCII code ,即上例的範例答案中 62 57 10 45 ......都是一個一個的字元而不是數字 ,請特別注意

ConsoleApplication3: A Mazing Problem  

題目: <br>
　　讀入一個陣列作為迷宮的資料 ,大小為 L*P(1<=L ,P<=10) ,以 0 代表沒有阻隔 ,而以 1 代表有阻隔 ,起始位置為 (1,1) ,出口位置為 (L,P) ,請設計一個演算法找出迷官的出路 <br>
限制: <br>
*   我們訂行走的方向為先嘗試北邊是否有出路,之後以順時鐘方向作嘗試 
*   一組答案的結束 ,請以兩個999表示 ,若結果為沒有路徑 ,請以兩個888表示 

要求: <br>
1.Input : 讀入指定之任意的 LxP 矩陣 <br>
2.Output: 找出一條從左上入右下出的路徑,用(i,j)來表示 <br>

example: <br>
    Input : 3              (<-- 有幾筆資料) <br>
              5 5            (<-- 迷宮大小 ROW*COL) <br>
              0 1 1 1 0      (<-- 迷宮的資料 , 0 為通路 , 1 為死路) <br>
              0 0 1 0 1 <br>
              1 1 0 1 0 <br>
              0 0 0 1 0 <br>
              1 1 0 0 0 <br>
              6 8 <br>
              0 1 1 1 0 1 0 1 <br>
              0 0 1 0 1 0 1 1 <br>
              1 0 1 1 0 1 1 0 <br>
              0 0 0 1 0 0 0 1 <br>
              1 1 0 1 0 1 0 0 <br>
              5 7 <br>
              0 1 1 1 0 1 0 <br>
              0 0 1 0 1 0 1 <br>
              1 0 1 1 0 1 1 <br>
              0 0 0 1 0 0 0 <br>
              1 1 0 0 0 1 0 <br>
  
    Output: <br>
              1 1        (<-- 路徑位置(ROW, COL) ) <br>
              2 2 <br>
              3 3 <br>
              4 3 <br>
              5 4 <br>
              5 5 <br>
              999 999    (<-- 一組答案的結束 ,請以兩個999表示) <br>
              888 888    (<-- 若結果為沒有路徑 ,請以兩個888表示) <br>
              999 999 <br>
              1 1 <br>
              2 2 <br>
              3 2 <br>
              4 3 <br>
              5 3 <br>
              5 4 <br>
              5 5 <br>
              4 5 <br>
              4 6 <br>
              4 7 <br>
              5 7 <br>
              999 999<br>

ConsoleApplication4: Evaluation of Expressions 

題目: <br>
　　依要求轉換成所指定的 infix, prefix expression <br>
要求: <br>
1.Input : 讀入第一行表示所要轉換的資料數 ,每筆資料包含兩行 ,第一行表示所要轉換的keyvalue ,第二行表示其expression <br>
2.Output: 表示成 infix 和 prefix expression <br>

限制(四種keyvalue所代表的意義); <br>
1 : 由 infix expression  轉 prefix expression <br>
2 : 由 prefix expression 轉 infix expression<br>

example: <br>
Input : 2            (<-- 此數字為測試資料筆數) <br>
　　　1            (<-- 第一組轉換expression的keyvalue) <br>
　　　A/B-C+D*E-A*C(infix expression)<br>
　　　2		(<-- 第二組轉換expression的keyvalue)<br>
　　　-/*A+BCDG    (prefix expression)<br>
<br>
Output: -+-/ABC*DE*AC        (prefix expression)<br>
　　　A*(B+C)/D-G          (infix expression)		 <br>
 <br>
　　　ps: operator只有 +,-,*,/,()<br>
   
ConsoleApplication5: Equivalence Class 

(A) Basic Concept <br>
      <a.1> The properties of the equivalence relation (≡): <br>
                (a) reflexive : x≡x <br>
                (b) symmetric : x≡y  =>  y≡x <br>
                (c) transitive : x≡y,y≡z  =>  x≡z <br>
      <a.2> We can use an equivalence relation to partition a set into equivalence classes. <br>
                Two members x and y of the input set, S, are in the same equivalence class if and only if x≡y. <br>
      <a.3> Example: <br>
                input set : S = {1,2,3,4,5,6}; <br>
                relations : 1≡2, 3≡4, 1≡4, 5≡6 <br>
                equivalence class: {1,2,3,4}; {5,6} <br>
(B) Programming <br>
              Input Format : (Assume we have two testing pattern.) <br>
  <br>
#1#        <-------Testing pattern 1 <br>
4           <------- The numbers of the relation  <br>
1 6         <------- Lower bound and upper bound of the input set  <br>
1 2         <------- Relation 1≡2  <br>
3 4         <------- 3≡4  <br>
1 4         <------- 1≡4  <br>
5 6         <------- 5≡6  <br>
#2#        <------Testing pattern 2<br> 
2 <br>
1 3 <br>
1 2 <br>
1 3<br>
            Remark : There is one space symbol between two members of the input set. <br>
              Output Format : <br>

#1#        <------Output of testing pattern 1 <br>
2            <------ The numbers of the equivalence class  <br>
1 2 3 4    <------ Class 1(after sorting,i.e.,(1<2<3<4),(5<6),(1<5))  <br>
5 6         <------ Class 2 <br>
#2#     <-----Output of testing pattern 2 <br>
1 <br>
1 2 3<br>
            Remark : There is one space symbol between two members of the input set.<br>
