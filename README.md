# Agent Tesla Malware Deobfuscation & Code Recovery

## Overview

본 저장소는 **:contentReference[oaicite:0]{index=0}** 악성코드를 대상으로 한  
**악성코드 분석 및 난독화 해제(Deobfuscation) 연구 프로젝트**입니다.

Agent Tesla는 2014년에 처음 등장한 .NET 기반 인포스틸러(Infostealer) 악성코드로,  
현재까지도 다양한 변종이 지속적으로 유포되고 있는 대표적인 정보 탈취형 악성코드입니다.

본 프로젝트는 실제 악성 행위를 목적으로 하지 않으며,  
**악성코드 분석 역량 향상과 보안 연구 목적**으로 수행되었습니다.

---

## Background

Agent Tesla는 다음과 같은 기능을 수행하는 것으로 알려져 있습니다.

- 웹 브라우저에 저장된 사용자 계정 정보 탈취
- 이메일 및 FTP 클라이언트 자격 증명 수집
- 키 입력(Keylogging) 기록
- 화면 스크린샷 캡처
- 수집된 정보의 원격 서버 전송

비교적 단순한 구조를 가지고 있음에도 불구하고,  
**높은 감염률과 안정적인 정보 탈취 능력**으로 인해 장기간에 걸쳐 활발히 사용되고 있습니다.

---

## Obfuscation Techniques

Agent Tesla에는 분석을 방해하기 위한 다양한 난독화 기법이 적용되어 있습니다.

- **문자열 암호화 (Encrypted Strings)**
- **switch–case 기반 함수 호출 흐름 난독화**
- 의미 없는 분기 및 제어 흐름 교란

이러한 기법으로 인해 원본 동작 로직을 직관적으로 파악하기 어렵습니다.

---

## Project Objective

본 프로젝트의 주요 목표는 다음과 같습니다.

- 난독화된 .NET 바이너리 **디컴파일**
- 암호화된 문자열을 **직접 분석 및 복호화**
- switch–case 기반 흐름을 **정상적인 제어 흐름으로 복원**
- 분석에 용이한 형태의 **복원 코드(Reconstructed Source Code)** 제공

이를 통해 Agent Tesla의 내부 동작을 보다 명확히 이해하고,  
**악성코드 분석 학습 및 방어 기술 연구**에 활용할 수 있도록 합니다.

---

