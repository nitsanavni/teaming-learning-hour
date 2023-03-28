# Introduction to Software Teaming - Learning Hour Description

## Context / Audience

-   At least two people, three is better
-   We assume no experience at all with Ensemble Programming or Pair Programming
-   Minimal software development experience

## Learning Goals

-   Get comfortable working this way
-   The importance of intentions and shared understanding
-   Experience strict [strong-style pairing](http://llewellynfalco.blogspot.com/2014/06/llewellyns-strong-style-pairing.html)

## Technical Preparations

For remote settings:

-   A shared timer (e.g. https://linkedtimer.com/, https://mobti.me/)
-   A workstation for collaborative coding (e.g. a [Gitpod](https://gitpod.io/docs) shared workspace, [Cyber Dojo](https://cyber-dojo.org/creator/home))
-   The workspace is at the starting position of the kata in the programming language most familiar to the team - I've used [CalcStats](https://sammancoaching.org/kata_descriptions/calc_stats.html) in a position that already has some code, but tests are failing
-   A shared board to take notes (e.g. Miro)
-   Slides / Frames

## Structure / Agenda

-   Setting the Stage - 1m (1m)
-   Connect - 5m (6m)
    -   Great Teamwork - 5m
-   Concept - 10m (16m)
    -   All the Brilliant minds - 2m
    -   Why would we work this way? - 3m
    -   Strong style + rotations - 5m
-   Concrete - Rules and Patterns - 36m (52m)
    -   Round #1 - Call-outs
    -   Round #2 - Share Screen
    -   Round #3 - Intention
    -   Round #4 - Typing
    -   Round #5 - Yes and..
    -   Round #6 - English First
-   Conclusions - 8m (60m)
    -   Learnings about Software Teaming

## Setting the Stage - 1m

Invite the team to actively participate in the Learning Hour.

Example:

> These Learning Hours and coaching sessions work best when you actively participate, so I invite you to get involved, ask questions, have fun, speak your mind.

## Connect - 5m

### Great Teamwork - 5m

Ask the team -

> What things help in achieving **great teamwork**?

Collect their answers as-is, no judgement, no corrections; Repeat answers out loud, and note them down for the whole team to see.

Follow-up Qs

-   Can you elaborate?
-   What do you mean by that?
-   Can you give an example?

## Concept

### What is Software Teaming?

**Explain** the following concepts, using some frames / slides.

#### AKA

Mob Programming / Ensemble Programming / [Software Teaming](https://softwareteaming.com/)

#### All the Brilliant Minds

> "All the brilliant minds working together on the same thing, at the same time, in the same space, and at the same computer"
>
> Woody Zuill

#### Approach and Patterns

-   A highly collaborative approach to working on software
-   A set of rules and patterns enabling it to be effective

### Why would we work this way?

Ask the team -

> Before we go into specific rules and patterns - **why would we work this way**?

Again collect the team's answers as-is, repeat them out loud and note them down.

Sometimes it helps to ask follow-up questions to go deeper than the initial surface level answers.

### Mindset

Explain -

The following mindset helps:

-   Learn from each other
-   Help each other
-   Treat each other with kindness, consideration, respect

### [Strong-style](http://llewellynfalco.blogspot.com/2014/06/llewellyns-strong-style-pairing.html)

Explain the two main roles: Typing, Talking.

It helps to have a visual representing the ensemble.

### Rotation

Explain that the team rotates through these roles.

## Concrete

The concrete part is structured as a sequence of "rounds". Each round has the team go through a full rotation, introducing a new practice. One small step at a time.

Go through as many rounds as time / energy permits, no need to complete them all.

I've randomized the order of names on the remote timer after each round, and rotated the team manually (using the "rotate" button).

Note: during the practice focus on collaboration aspects of the work (e.g. clearly stating intentions), the code itself is less important.

### Round #1 - Call-outs

-   Have the team add their names to an **online timer** (e.g. [mobti.me](https://mobti.me/))
-   Practice:

    > "I'm {name}, and I'm **typing**"

    > "I'm {name}, and I'm **talking**"

    > "I'm {name}, and I'm **next**"

### Round #2 - Share Screen

-   Introduce the kata (I've used [CalcStats](https://sammancoaching.org/kata_descriptions/calc_stats.html))
-   Share the link to the workstation and show the team where the code and tests are, and how to run them
-   Practice:

    > "I'm {name}, I'm typing, and **I'm sharing my screen**"

    (the Typist should actually share their screen)

    > "I'm {name}, I'm talking, and **I can see your screen**"

    > "I'm {name}, and I'm next"

### Round #3 - Intention

In this round the person Talking will say at least one **intention**, the person Typing listens, follows the intention except for actually typing. Again - **no actual typing yet**.

You can share a few ideas for intentions, e.g.:

> "Let's run the tests again."

> "Please go to the other file."

> "Let's fix the failing test by..."

> "Please rename method CalcStats to CalculateStatistics."

> "Can we have a look at the **kata description** again?"

### Round #4 - Typing

In this round we start actually typing and changing code.

### Round #5 - Yes and...

The person Talking tries to follow **previous intentions**, as opposed to completely changing direction.

Example:

Talker:

> "We were about to rename this method, so let's go ahead with it."

### Round #6 - English First

The person Typing tries to write a comment in the code with the Talker's intention before actually changing code.

Example:

Talker:

> "Let's add a new test for **MaximumValue**"

Typist adds this comment in the code:

```cs
// TODO - add a test for MaximumValue
```

## Conclusions - 7m

### Learnings about Software Teaming

Ask the team -

> What have you learned today about Software Teaming?

Collect answers, repeat out-loud, write them down and potentially probe further if curious.

### Reference and Resources

Share useful links with the team.
