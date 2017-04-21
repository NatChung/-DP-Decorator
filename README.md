# -DP-Decorator
## Simple Player
1. SUT1: Player, Mock:IMediaRender, Action: Player.Play, Expected: Mock.AddVideo & Mock.AddAudio
2. SUT12: Player, Mock:IMediaRender, Action: Constroctor, Expected: Mock.View
## Resizeable Player
1. SUT2: ResizeableRender, Mock:IMediaRender, Action: AddVideo, Expected: Mock.AddVideo
2. SUT3: ResizeableRender, Mock:IMediaRender, Action: AddAudio, Expected: Mock.AddAudio
3. SUT4: ResizeableRender, Action: Constroctor, Expected: ResizeableRender.View.Medthd.Name = "OnTouch"
## Buffer Player
1. [Modify] SUT2: ResizeableRender -> MediaRenderDecorator, Mock:IMediaRender, Action: AddVide, Expected: Mock.AddVideo
2. [Modify] SUT3: ResizeableRender -> MediaRenderDecorator, Mock:IMediaRender, Action: AddAudio, Expected: Mock.AddAudio
3. SUT4: BufferRender, Mock:IMediaRender, Action: AddVideo(n time), Expected: Mock.AddVideo(1 time)
4. SUT5: BufferRender, Mock:IMediaRender, Action: AddAudio(n time), Expected: Mock.AddAudio(1 time)
## Jitter Buffer Player
### Create MedidaSource (extern IMediaSouce, IMediaBuffer)
1. SUT6: MediaSource, Action: AddVideo(n time), Expected: OnVideo delegate 
2. SUT7: MediaSource, Action: AddAudio(n time), Expected: OnAudio delegate 
3. SUT8: JitterBuffer, Mock: IMeidaBuffer, Action: AddVidoe(n time), Expected: Mock.OnVideo delegate 
4. SUT9: JitterBuffer, Mock: IMeidaBuffer, Action: AddAudio(n time), Expected: Mock.OnAudio delegate 
### Repleace AddVideo/AddAudio with IMediaSource
1. [Modify] SUT1: Player, Mock:ImediaRender, Action: Player, Expected: Mock.MediaSource.AddAudio & Mock.MediaSource.AddVidoe
## File Buffer Player
1. SUT10: FileBuffer, Mock: IMediaBuffer, Action: AddVideo(n time), Expected: Mock.OnVideo delegate
2. SUT11: FileBuffer, Mock: IMeidaBuffer, Action AddAudio(n time), Expected: Mock.OnAudio delegate
