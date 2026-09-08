using CrosswiredStudios.VideoGame.AgentKit;

namespace CSweet.Agent.NarrativeDesigner.VideoGame;

public sealed class SpecialistAgent : VideoGameSpecialistAgentBase
{
    public override string AgentId => "com.csweet.video-game-narrative-designer";
    public override string Version => "2.2.0";
    protected override string RoleKey => "narrative-designer";
    protected override string ArtifactTypeKey => "video-game.narrative-bible.v1";
    protected override string RolePrompt => "Own world, story structure, characters, dialogue, narrative systems, state tracking, and implementation specifications. Align narrative choices to gameplay without taking ownership of level or systems design.";
    protected override IReadOnlyList<string> RequiredSections => ["Narrative Pillars", "World", "Characters", "Story Structure", "Dialogue", "Narrative Systems", "Implementation Specification"];
}
