# 五張撲克牌-賭場版

## 主要功能

輸入押注金額並確認後，系統會隨機發放五張撲克牌，玩家可視策略點擊需更換的手牌將其翻面，並進行一次換牌，按下「判斷牌型」按鈕後，系統會依照撲克牌規則與內建賠率表（如：皇家同花順、四條、葫蘆等）自動結算，若為雜牌則賠率為 0 並扣除押注金，系統會即時計算淨利與更新總資金，並設有「重新開始」功能。

## 使用方法

1.程式開始時會顯示預設總資金 1,000,000，並將「發牌」、「換牌」、「判斷牌型」按鈕上鎖，牌面朝下

<img width="344" height="313" alt="image" src="https://github.com/user-attachments/assets/d297e470-e631-4e53-bb50-9e94197506e0" />
<br>

2.輸入押注金額，當輸入不符合以下規定時會跳出錯誤訊息提醒使用者重新輸入
-	情況一： 押注金額小於等於 0

<img width="344" height="250" alt="image" src="https://github.com/user-attachments/assets/99f80445-4e69-4ea3-ba09-242de88858f5" />
<br>

-	情況二： 押注金額大於總資金

<img width="344" height="250" alt="image" src="https://github.com/user-attachments/assets/6748c07b-0503-459a-8261-b409415c9834" />
<br>

- 情況三： 輸入不合法的字元(非數字)

<img width="344" height="250" alt="image" src="https://github.com/user-attachments/assets/4aeaafb9-855b-4fe6-b337-4e4b14854443" />
<br>

3.點選押注後跳出「已押注，請發牌」的提示詞，此時金額不得更改，解鎖「發牌」按鈕

<img width="344" height="313" alt="image" src="https://github.com/user-attachments/assets/1ab32342-3351-4b38-8349-7c38b27c7b02" />
<br>

4.按下「發牌」後，桌面上會顯示隨機抽出的五張牌，若對手牌不滿意，可直接點擊想要換掉的撲克牌（該牌會翻轉至背面圖案），接著點擊「換牌」按鈕，系統會配發新的牌來替換翻背的卡片
- 換牌前(「判斷牌型」按鈕上鎖，如果沒有想換的牌可以直接點擊換牌，不會更改牌型)

<img width="344" height="313" alt="image" src="https://github.com/user-attachments/assets/cc596399-fad4-462c-87e5-dcc537858bf5" />
<br>

- 換牌後(解鎖「判斷牌型」按鈕，「換牌」按鈕重新上鎖)

<img width="344" height="313" alt="image" src="https://github.com/user-attachments/assets/eccb9abf-52e8-4bc6-9ff8-7e07bc7f6fb7" />
<br>

5.按下「判斷牌型」按鈕會輸出文字說明牌型，並比對賠率表計算結果，結算後的金額會同步更新至總資金

<img width="344" height="300" alt="image" src="https://github.com/user-attachments/assets/60662e10-cc71-4a4f-a68b-caf598421ea9" />
<br>

- 有牌型： 獲得金額以「紅色字體」並加上 + 號標示

<img width="344" height="313" alt="image" src="https://github.com/user-attachments/assets/04857da8-264f-4b5b-ad17-3be7d4bb835e" />
<br>

- 雜牌： 損失金額以「綠色字體」並加上 - 號標示

<img width="344" height="313" alt="image" src="https://github.com/user-attachments/assets/4a2414c4-cef7-4554-ae2b-4d402bf01707" />
<br>

6.點擊「重新開始」按鈕，系統會將總資金恢復至初始值 1,000,000，將所有卡牌翻回背面並停用，清空歷史紀錄以利重新計算

<img width="344" height="313" alt="image" src="https://github.com/user-attachments/assets/10004901-fae1-4a28-985e-db82e5a0cc84" />

