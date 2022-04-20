语言 : [ENGLISH](./README.md) | 简体中文 
<h1 align="center">Titanfall2-SkinTool</h1>

<div align="center">泰坦陨落二和APEX S3版本的皮肤安装工具，个人渣作，轻喷</div><br>

## 目录

- [前言](#前言)
- [支持的操作](#支持的操作)
- [控制台版本](#控制台版本)
- [备份文件](#备份文件)
- [问题](#问题)
- [工作计划](#工作计划)
- [贡献](#贡献)

## 前言

一定要看文档说明！！！<br>
仅供学习用途，不鼓励修改原皮以外的皮肤；<br>
本工具将永远不会支持修改其他付费皮肤以及传家宝<br>
也不支持在最新版本的APEX官服中使用本工具，封禁警告！！！

格式要求:<br>
[请优先查看本文件](Documents/请优先查看本文件.txt)<br>
[APEX S3武器格式要求](Documents/APEX_S3武器格式要求.docx)<br>
[泰坦陨落二武器格式要求](Documents/泰坦陨落二武器格式要求.docx)<br>
[泰坦陨落二铁驭贴图说明文档](Documents/泰坦陨落二铁驭贴图说明文档.docx)<br>
[Legion中的贴图名称](Documents/Legion中的贴图名称.txt)

## 支持的操作

泰坦陨落二部分目前支持铁驭皮肤、铁驭武器、泰坦武器;


APEX S3版本支持绝大部分武器;

## 控制台版本
参数： <游戏路径> <皮肤压缩包路径> [<更多的皮肤压缩包路径>] [-verbose]? [-quit]?

可选参数：

--v, -verbose : 打印更多信息

--q, -quit : 安装完成后关闭控制台，无需等待用户确认

示例:

Titanfall2-SkinTool.exe "C:\Program Files (x86)\Steam\steamapps\common\Titanfall2\Titanfall2.exe" "C:\Users\whothis\Downloads\KraberSkin.zip" "C:\Users\whothis\Downloads\CarSkin.zip" --q

## 备份文件

### 文件位置

泰坦陨落二<br>
**路径**:游戏目录\r2\paks\Win64\
<br>
APEX S3<br>
**路径**:游戏目录\paks\Win64\


### 我需要备份哪些文件

泰坦陨落二:
<br>
- pc_stream.starpak
- pc_stream(03).starpak
<br>

APEX S3:
<br>
- pc_all.starpak
- pc_all.opt.starpak
- pc_all(01).opt.starpak
- pc_all(02).opt.starpak


## 问题
硬编码<br>
数据存储<br>
压缩BC7U格式图片时可能会使CPU超载<br>


## 工作计划

代码规范
<br>
自定义导入
<br>
更多功能 

## 贡献
欢迎提出建议! [新建一个问题描述](https://github.com/zxcPandora/Titanfall2-SkinTool/issues/new) 或提交推拉请求。

### 贡献者

这个项目的存在要感谢以下所有做出贡献的人：
<a href="https://github.com/zxcPandora/Titanfall2-SkinTool/graphs/contributors"><br>
  <img src="https://avatars.githubusercontent.com/u/81985226?v=4" width="128" height="128">
  <img src="https://avatars.githubusercontent.com/u/18037145?v=4" width="128" height="128">
  <img src="https://avatars.githubusercontent.com/u/18683538?v=4" width="128" height="128">
  <img src="https://avatars.githubusercontent.com/u/37307454?v=4" width="128" height="128">
</a>
