# Aula de UI
Projeto de exemplo de UI usando Unity.

Design da interface usada neste projeto está [disponível no Figma](https://www.figma.com/design/LJ30W3fWc8eZkDteBKhgml/AulaUI?node-id=0-1&t=GzMLrrUds6l2yMM7-1).


## Cenas
- [Controles](Assets/Scenes/Controles.unity): todos os controles de UI
- [NavegacaoControles](Assets/Scenes/NavegacaoControles.unity): navegação entre [controles selecionáveis](https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/script-SelectableNavigation.html)
- [HUD+MissionPopup](Assets/Scenes/HUD+MissionPopup.unity): uma tela implementada (link pro [design](https://www.figma.com/file/LJ30W3fWc8eZkDteBKhgml/AulaUI))
  + [UI responsiva](https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/HOWTO-UIMultiResolution.html)
    usando âncoras e [CanvasScaler](https://docs.unity3d.com/Documentation/Manual/script-CanvasScaler.html)
  + [9-Slicing](https://docs.unity3d.com/Manual/9SliceSprites.html)
  + Frame Debugger: com e sem Sprite Atlas
- [3D+UI](Assets/Scenes/3D+UI.unity): como mostrar elementos 3D dentro da UI
  + Câmera posicionada certinho
  + Câmera + [Viewport Rect](https://docs.unity3d.com/Manual/class-Camera.html)
  + Câmera + [Render Texture](https://docs.unity3d.com/Manual/class-RenderTexture.html)


## Referências
- Comparação entre sistemas de UI da Unity: https://docs.unity3d.com/Manual/UI-system-compare.html
- Manual uGUI: https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/index.html
- Dicas de otimização para UIs: https://unity.com/how-to/unity-ui-optimization-tips


## Créditos
- Fonte Acme por Juan Pablo del Peral, Huerta Tipográfica: https://fonts.google.com/specimen/Acme
- Ícones Heart, Bacon, Bread, Chesse e Rocket por EmojiOne: https://github.com/EmojiTwo/emojitwo
- Sprite Yellow Button por Kenney (UI Pack): https://kenney.nl/assets/ui-pack


## Licenças
- Texturas [FundoPopup](Assets/Sprites/gilzoide-FundoPopup.png), [BotãoCircular](Assets/Sprites/gilzoide-BotãoCircular.png) e [pixel](Assets/Sprites/gilzoide-pixel.png): [CC0 1.0 Universal](https://creativecommons.org/publicdomain/zero/1.0/)
- Projeto Unity, cenas, prefabs, código: [The Unlicense](https://unlicense.org/)
