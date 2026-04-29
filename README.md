# 五張撲克牌-賭場版

## 主要功能

輸入押注金額並確認後，系統會隨機發放五張撲克牌，玩家可視策略點擊需更換的手牌將其翻面，並進行一次換牌，按下「判斷牌型」按鈕後，系統會依照撲克牌規則與內建賠率表（如：皇家同花順、四條、葫蘆等）自動結算，若為雜牌則賠率為 0 並扣除押注金，系統會即時計算淨利與更新總資金，並設有「重新開始」功能。

## 使用方法

1.程式開始時會顯示預設總資金 1,000,000 ，並將「發牌」、「換牌」、「判斷牌型」按鈕上鎖，牌面朝下

<img width="344" height="313" alt="image" src="https://github.com/user-attachments/assets/d297e470-e631-4e53-bb50-9e94197506e0" />

2.輸入押注金額，當輸入不符合以下規定時會跳出錯誤訊息提醒使用者重新輸入
-	情況一： 押注金額小於等於 0

<img width="344" height="250" alt="image" src="https://github.com/user-attachments/assets/99f80445-4e69-4ea3-ba09-242de88858f5" />

-	情況二： 押注金額大於總資金

<img width="344" height="250" alt="image" src="https://github.com/user-attachments/assets/6748c07b-0503-459a-8261-b409415c9834" />

- 情況三： 輸入不合法的字元(非數字)

<img width="344" height="250" alt="image" src="https://github.com/user-attachments/assets/4aeaafb9-855b-4fe6-b337-4e4b14854443" />
