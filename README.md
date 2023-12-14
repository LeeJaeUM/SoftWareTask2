# SoftWareTask2
<!-- 프로젝트 제목 -->

<p>음악에 맞춰 마우스를 클릭하는 간단한 리듬게임입니다.</p>

<!-- 설치 -->

<h2>설치</h2>

<p>유니티 에디터에서 UNITY 2022 LTS버전을 설치하면 직접 확인할 수 있습니다.:</p>


<!-- 사용법 -->


<!-- 프로젝트 이미지 -->

<h2>프로젝트 이미지</h2>
<img src="https://github.com/LeeJaeUM/SoftWareTask2/assets/106094800/7957f3a6-484d-4346-a125-a2f20ac22482" alt="타이틀화면">
<img src="https://github.com/LeeJaeUM/SoftWareTask2/assets/106094800/155de030-f779-4570-86c2-ba99eb1e7a9a" alt="인게임">

<h3>결과화면 이미지</h3>
<img src="https://github.com/LeeJaeUM/SoftWareTask2/assets/106094800/41a4df79-e839-4405-8ff0-052c5e53d456" alt="결과화면">


<p>타이틀 화면에서 Start를 선택하거나 Exit를 눌러서 게임을 시작하거나 종료하세요.</p>
<p>게임을 시작하면 타이밍에 맞게 화면을 마우스로 누르세요.</p>
<p>알맞은 타이밍에 눌렀는 지 텍스트로 표현합니다.</p>


<!-- 스크립트 설명 -->
<h3>스크립트 설명</h3>
<p>AudioEventTrigger.cs : 음악의 시간에 맞춰 노트 발생 시간을 정합니다.</p>
<p>BackgroundMusic.cs : 음악을 플레이합니다.</p>
<p>GameEndUI : 결과화면의 ui를 관리합니다 </p>
<p>GameManager  : 게임 전체를 관리하며 씬 이동과 게임종료 인식을 맡습니다.</p>
<p>GameTimer  : 테스트버튼을 눌러서 노트 발생시간을 텍스트 파일로 작성합니다..</p>
<p>PressNote  : 마우스 클릭을 인식하며 노트 인식 타이밍을 결정하고 점수를 올립니다.</p>
<p>TextController  : 게임 시작 시 게임 시작을 알리는 text UI를 관리합니다.</p>
<p>UIManager  : 점수 text를 관리합니다.</p>
