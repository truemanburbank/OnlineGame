# C# TCP 서버-클라이언트 멀티플레이 게임

본 프로젝트는 C#으로 구현한 TCP 서버와 Unity 클라이언트 간의 실시간 멀티플레이어 게임 통신을 목표로 진행되었습니다.  
서버-클라이언트 구조 설계와 패킷 포맷 정의를 통해 캐릭터 이동, 스킬, 상태 등의 게임 콘텐츠 데이터를 효율적으로 동기화합니다.

---

## 주요 기능

- TCP 소켓을 이용한 안정적인 서버-클라이언트 연결 및 비동기 통신 처리  
- 패킷 구조 직접 설계 및 Google Protocol Buffers를 활용한 데이터 직렬화 최적화  
- SendBufferHelper 클래스를 통한 효율적인 버퍼 관리 및 메모리 최적화  
- PositionInfo 프로퍼티 변경 시 캐릭터 상태(좌표, 방향, 상태) 자동 동기화  
- Unity 네트워크 이벤트 기반 사용자 입력 및 게임 상태 처리  
- 네트워크 지연 및 예외 처리 로직 구현  

---

## 학습 포인트

- TCP 네트워크 통신의 흐름과 비동기 데이터 송수신 경험  
- 멀티스레딩 환경에서 안정적인 통신 처리 및 예외 대응  
- 실시간 게임 상태 동기화를 위한 패킷 설계와 최적화  
- Unity와 C# 서버 간 연동 및 멀티플레이어 게임 로직 구현  
- 버퍼 관리와 데이터 직렬화 최적화 방법 이해  

---

## 실행 방법

1. 서버: C# 콘솔 프로젝트 실행  
2. 클라이언트: Unity 프로젝트 빌드 및 실행  
3. 서버와 클라이언트 간 TCP 연결 확인 후 게임 플레이  

---

## 참고 링크

- [프로젝트 블로그 글 1](https://hmmterestinguri.tistory.com/135)  
- [프로젝트 블로그 글 2](https://hmmterestinguri.tistory.com/136)  
- [프로젝트 블로그 글 3](https://hmmterestinguri.tistory.com/140)  
- [프로젝트 블로그 글 4](https://hmmterestinguri.tistory.com/144)  
- [프로젝트 블로그 글 5](https://hmmterestinguri.tistory.com/145)
- [시연 영상](https://youtu.be/h8u90-SAG0g)  
- [참고 강의](https://www.inflearn.com/course/%EC%9C%A0%EB%8B%88%ED%8B%B0-mmorpg-%EA%B0%9C%EB%B0%9C-part7/dashboard)
---
